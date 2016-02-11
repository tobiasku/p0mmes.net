using pOmmes.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pOmmes.Data
{
    public interface IpOmmesDataDL
    {
        //--------------------------------------------------------------------------
        //-- Methods
        //--------------------------------------------------------------------------
        Collection<T> Get<T>() where T : Base;

        Collection<T> Get<T>(Dictionary<string, object> filter) where T : Base;

        T Find<T>(string objectId) where T : Base;

        void Put<T>(Collection<T> collectionToPut) where T : Base;

        void Post<T>(Collection<T> collectionToPost) where T : Base;

        void Delete<T>(Collection<T> collectionToDelete) where T : Base;

        void Put<T>(T toPut) where T : Base;

        void Post<T>(T toPost) where T : Base;

        void Delete<T>(T toDelete) where T : Base;
    }
}
