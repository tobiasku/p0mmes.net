using pOmmes.Common;
using pOmmes.Common.Dic;
using pOmmes.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pOmmes.Data
{
    public class pOmmesDataBL : IpOmmesDataBL
    {
        IpOmmesDataDL pOmmesDataDL;

        public pOmmesDataBL()
        {
            pOmmesDataDL = Dic.Get<IpOmmesDataDL>();
        }

        //--------------------------------------------------------------------------
        //-- Methods
        //--------------------------------------------------------------------------
        public Collection<T> Get<T>() where T : Base
        {
            return pOmmesDataDL.Get<T>();
        }

        public Collection<T> Get<T>(Dictionary<string, object> filter) where T : Base
        {
            return pOmmesDataDL.Get<T>(filter);
        }

        public T Find<T>(string objectId) where T : Base
        {
            return pOmmesDataDL.Find<T>(objectId);
        }

        public void Put<T>(Collection<T> collectionToPut) where T : Base
        {
            foreach (var toPut in collectionToPut)
            {
                toPut.UpdatedAt = DateTime.Now;
            }

            pOmmesDataDL.Put<T>(collectionToPut);
        }

        public void Post<T>(Collection<T> collectionToPost) where T : Base
        {
            foreach (var toPost in collectionToPost)
            {
                toPost.CreatedAt = DateTime.Now;
            }

            pOmmesDataDL.Post<T>(collectionToPost);
        }

        public void Delete<T>(Collection<T> collectionToDelete) where T : Base
        {
            pOmmesDataDL.Delete<T>(collectionToDelete);
        }

        public void Put<T>(T toPut) where T : Base
        {
            toPut.UpdatedAt = DateTime.Now;

            pOmmesDataDL.Put<T>(toPut);
        }

        public void Post<T>(T toPost) where T : Base
        {
            toPost.CreatedAt = DateTime.Now;

            pOmmesDataDL.Post<T>(toPost);
        }

        public void Delete<T>(T toDelete) where T : Base
        {
            pOmmesDataDL.Delete<T>(toDelete);
        }
    }
}
