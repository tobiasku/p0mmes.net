using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pOmmes.Common
{
    public class State
    {
        #region constructors
        /// <summary>
        /// Parameter object for calling asynchronously coupled Methods. Given back after Competion.
        /// </summary>
        /// <param name="wcbOk">where to call back, if ok</param>
        /// <param name="wcbNok">where to call back, if not ok</param>
        /// <param name="inner">Object of same Type (State) given back to calling Method</param>
        /// <param name="data">Returned data, empty at calling time</param>
        public State(Guid guid, WaitCallback wcbOk, WaitCallback wcbNok, State inner, object data)
        {
            Guid = guid;
            WcbOk = wcbOk;
            WcbNok = wcbNok;
            InnerState = inner;
            Data = data;
        }
        public State(WaitCallback wcbOk, WaitCallback wcbNok, State inner, object data)
            : this(Guid.NewGuid(), wcbOk, wcbNok, inner, data)
        { }

        public State(WaitCallback wcbOk, WaitCallback wcbNok, State inner)
            : this(Guid.NewGuid(), wcbOk, wcbNok, inner, null)
        { }
        public State(WaitCallback wcbOk, WaitCallback wcbNok)
            : this(Guid.NewGuid(), wcbOk, wcbNok, null, null)
        { }
        public State(Guid guid, WaitCallback wcbOk, WaitCallback wcbNok, State inner)
            : this(guid, wcbOk, wcbNok, inner, null)
        { }
        public State(Guid guid, WaitCallback wcbOk, WaitCallback wcbNok)
            : this(guid, wcbOk, wcbNok, null, null)
        { }
        public State()
            : this(Guid.NewGuid(), null, null, null, null)
        { }
        #endregion


        public State Clone()
        {
            return new State(Guid.NewGuid(), this.WcbOk, this.WcbNok, this.InnerState, this.Data);
        }
        public State Clone(object data)
        {
            return new State(Guid.NewGuid(), this.WcbOk, this.WcbNok, this.InnerState, data);
        }


        #region Members
        public Guid Guid { get; set; }
        public WaitCallback WcbOk { get; private set; }
        public WaitCallback WcbNok { get; private set; }
        public State InnerState { get; private set; }
        public object Data { get; set; }
        #endregion
    }
}
