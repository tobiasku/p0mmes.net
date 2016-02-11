using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pOmmes.Common.Dic
{
    public class Dic
    {
        public static UnityContainer container = new UnityContainer();

        public static T Get<T>()
        {
            return container.Resolve<T>();
        }

        public static void Put<T, G>() where G : T
        {
            T instance = (T)Activator.CreateInstance(typeof(G));

            container.RegisterInstance<T>(instance);
        }

        public static void Put<Y>(Y instance)
        {
            container.RegisterInstance<Y>(instance);
        }
    }
}
