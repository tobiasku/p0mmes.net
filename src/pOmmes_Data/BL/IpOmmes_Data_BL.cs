using pOmmes.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pOmmes.Data
{
    public interface IpOmmesDataBL
    {
        //--------------------------------------------------------------------------
        //-- Methods
        //--------------------------------------------------------------------------
        Collection<T> Get<T>() where T : Base;

        Collection<T> Get<T>(string filterString) where T : Base;

        T Find<T>(string objectId) where T : Base;

        void Put<T>(Collection<T> collectionToPut) where T : Base;

        void Post<T>(Collection<T> collectionToPost) where T : Base;

        void Delete<T>(Collection<T> collectionToDelete) where T : Base;
    }
}
