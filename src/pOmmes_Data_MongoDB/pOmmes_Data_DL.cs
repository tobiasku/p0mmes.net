using pOmmes.Common;
using pOmmes.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pOmmes.Data.MongoDB
{
    public class pOmmesDataDL : IpOmmesDataDL
    {
        //--------------------------------------------------------------------------
        //-- Methods
        //--------------------------------------------------------------------------
        public Collection<T> Get<T>() where T : Base
        {
            return null;
        }

        public Collection<T> Get<T>(string filterString) where T : Base
        {
            return null;
        }

        public T Find<T>(string objectId) where T : Base
        {
            return null;
        }

        public void Put<T>(Collection<T> collectionToPut) where T : Base
        {

        }

        public void Post<T>(Collection<T> collectionToPost) where T : Base
        {

        }

        public void Delete<T>(Collection<T> collectionToDelete) where T : Base
        {

        }
    }
}
