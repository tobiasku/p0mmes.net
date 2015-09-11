using DryIoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pOmmes.Common.Dic
{
    public class Dic
    {
        public static Container container = new Container();

        public static T Get<T>()
        {
            return container.Resolve<T>();
        }
       
        public static void Put<T,G>() where G : T
        {
            container.Register<T,G>(Reuse.Singleton);
        }
    }
}
