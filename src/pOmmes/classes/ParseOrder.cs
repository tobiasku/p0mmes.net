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
    [ParseClassName("Order")]
    public class ParseOrder : ParseObject
    {
        [ParseFieldName("userId")]
        public ParseUser User
        {
            get { return (ParseUser)this["userId"]; }
            set { SetProperty<ParseUser>(value as ParseUser); }
        }

        [ParseFieldName("price")]
        public double Price
        {
            get { return GetProperty<double>(); }
            set { SetProperty<double>(value); }
        }

        public Collection<ParseOrderPosition> OrderPositions
        {
            get { return null; }
            set { }
        }    
    }
}
