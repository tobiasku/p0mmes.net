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
    [ParseClassName("Vote")]
    public class ParseVote : ParseObject
    {
        [ParseFieldName("userId")]
        public ParseUser User
        {
            get { return (ParseUser)this["userId"]; }
            set { SetProperty<ParseUser>(value as ParseUser); }
        }

        [ParseFieldName("restaurantId")]
        public ParseRestaurant Restaurant
        {
            get { return (ParseRestaurant)this["restaurantId"]; }
            set { SetProperty<ParseRestaurant>(value as ParseRestaurant); }
        }
    }
}
