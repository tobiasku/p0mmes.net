using Parse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pOmmes
{
    [ParseClassName("Company")]
    public class Company : ParseObject
    {
        [ParseFieldName("name")]
        public string Name
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("phoneNumber")]
        public string PhoneNumber
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        public static async void Query(State callback)
        {
            // var query = from company in new ParseQuery<Company>() select (company);

            var query = new ParseQuery<Company>();//..WhereLessThanOrEqualTo("rupees", ((Player)ParseUser.CurrentUser).Rupees);

            Collection<Company> result = new Collection<Company>((await query.FindAsync()).ToList<Company>());



            if (result != null)
            {
                callback.Data = result;
                Callback.Done(callback);
            }
            else
            {
                callback.Data = null;
                Callback.Error(callback);
            }
        }
    }
}
