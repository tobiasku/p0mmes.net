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
    [ParseClassName("FoodToOption")]
    public class ParseFoodToOption : ParseObject
    {
        [ParseFieldName("price")]
        public double Price
        {
            get { return GetProperty<double>(); }
            set { SetProperty<double>(value); }
        }

        [ParseFieldName("foodId")]
        public ParseArticle Article
        {
            get { return (ParseArticle)this["foodId"]; }
            set { SetProperty<ParseArticle>(value as ParseArticle); }
        }

        [ParseFieldName("restaurantId")]
        public ParseRestaurant Restaurant
        {
            get
            {
                try
                {
                    return (ParseRestaurant)this["restaurantId"];
                }
                catch
                {
                    return null;
                }
            }
            set { SetProperty<ParseRestaurant>(value as ParseRestaurant); }
        }

        [ParseFieldName("sizeId")]
        public ParseSize Size
        {
            get
            {
                try
                {
                    return (ParseSize)this["sizeId"];
                }
                catch
                {
                    return null;
                }
            }
            set { SetProperty<ParseSize>(value as ParseSize); }
        }

        [ParseFieldName("optionId")]
        public ParseOption Option
        {
            get { return (ParseOption)this["optionId"]; }
            set { SetProperty<ParseOption>(value as ParseOption); }
        }

        public override string ToString()
        {
            return Option.Name + " (+" + Price.ToString("0.00") + " €)";
        }

        public override bool Equals(object obj)
        {
            ParseFoodToOption y = obj as ParseFoodToOption;
            if (y != null)
            {
                return (this.Option.ObjectId.Equals(y.Option.ObjectId));
            }
            else
            {
                return false;
            }
        }
    }
}
