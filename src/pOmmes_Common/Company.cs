using Parse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    [ParseClassName("Company")]
    public class Company : ParseObject
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        [ParseFieldName("Name")]
        public string Name
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("PhoneNumber")]
        public string PhoneNumber
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }
    }
}
