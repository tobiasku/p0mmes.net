using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pOmmes
{
    public static class Callback
    {
        #region Start callback method with timeout tracing
        public static void StartMethod(WaitCallback timeoutCallback, WaitCallback methodToStart, int timeout)
        {
            try
            {
                if (timeoutCallback == null)
                {
                    throw new ArgumentException("Callback-Methode muss gesetzt sein", "timeoutCallback");
                }
                if (methodToStart == null)
                {
                    throw new ArgumentException("Methode zum Aufrufen muss gesetzt sein", "methodToStart");
                }

                Thread thread = new Thread(new ThreadStart(() =>
                {
                    AutoResetEvent signal = new AutoResetEvent(false);
                    Thread currentThread = null;

                    ThreadPool.QueueUserWorkItem(
                    (o) =>
                    {
                        currentThread = Thread.CurrentThread;
                        methodToStart.Invoke(null);
                        signal.Set();
                    });

                    if (!signal.WaitOne(timeout, false))
                    {
                        ThreadPool.QueueUserWorkItem(timeoutCallback, new TimeoutException("The method " + methodToStart.Method.Name + " runs into timeout."));
                        if (currentThread != null)
                        {
                            currentThread.Abort();
                        }
                    }
                }));
                thread.Start();
            }
            catch
            {
                throw;
            }
        }

        public static void StartMethod(WaitCallback timeoutCallback, WaitCallback methodToStart)
        {
            StartMethod(timeoutCallback, methodToStart, 30000);
        }
        #endregion

        #region Callbacks in case of Success
        private static void InnerDone(State state)
        {
            if (state != null && state.WcbOk != null)
            {
                ThreadPool.QueueUserWorkItem(state.WcbOk, state);
            }
        }
        private static void InnerDone(State state, object data)
        {
            if (state != null && state.WcbOk != null)
            {
                state.Data = data;
                ThreadPool.QueueUserWorkItem(state.WcbOk, state);
            }
        }

        /// <summary>
        /// Callback in case of success
        /// Returned object is asumed to be already referenced by state.Data
        /// </summary>
        /// <param name="state">Parameter object, returned uncloned</param>
        public static void Done(State state)
        {
            InnerDone(state);
        }
        /// <summary>
        /// Callback in case of success
        /// Returned object is explicitly given
        /// </summary>
        /// <param name="state">Parameter object, returned uncloned</param>
        /// <param name="data">object to be returned, is writen into state.Data</param>
        public static void Done(State state, object data)
        {
            InnerDone(state, data);
        }
        #endregion

        #region Callbacks in case of error
        private static void InnerError(State state)
        {
            if (state != null && state.WcbNok != null)
            {
                ThreadPool.QueueUserWorkItem(state.WcbNok, state);
            }
        }
        private static void InnerError(State state, Exception e)
        {
            if (state != null && state.WcbNok != null)
            {
                state.Data = e;
                ThreadPool.QueueUserWorkItem(state.WcbNok, state);
            }
        }

        /// <summary>
        /// Callback in case of error
        /// Returned exception is asumed to be already referenced by state.Data
        /// </summary>
        /// <param name="state">Parameter object, returned uncloned</param>
        public static void Error(State state)
        {
            InnerError(state);
        }
        /// <summary>
        /// Callback in case of error
        /// Returned exception is explicitly given
        /// </summary>
        /// <param name="state">Parameter object, returned uncloned</param>
        /// <param name="e">Exception to be returned, is writen into state.Data</param>
        public static void Error(State state, Exception exception)
        {
            InnerError(state, exception);
        }
        #endregion

        public static object[] CheckCallbackResult(object result)
        {
            State state = result as State;
            if (result != null)
            {
                if (state.Data != null &&
                    state.Data is object[])
                {
                    object[] results = (object[])state.Data;
                    if (results != null &&
                        results.Length > 0)
                    {
                        return results;
                    }
                }
            }
            return null;
        }
    }
}
