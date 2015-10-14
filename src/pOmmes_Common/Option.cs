using Parse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    [ParseClassName("Option")]
    public class Option : ParseObject
    {        //--------------------------------------------------------------------------
             //-- Fields
             //--------------------------------------------------------------------------
        [ParseFieldName("Name")]
        public string Name
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }
    }
}
