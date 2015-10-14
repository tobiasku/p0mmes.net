using Parse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    [ParseClassName("Restaurant")]
    public class Restaurant : ParseObject
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

        [ParseFieldName("LogoURL")]
        public string LogoURL
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }
    }
}
