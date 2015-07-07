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
    [ParseClassName("FoodToSize")]
    public class ParseFoodToSize : ParseObject
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

        [ParseFieldName("sizeId")]
        public ParseSize Size
        {
            get { return (ParseSize)this["sizeId"]; }
            set { SetProperty<ParseSize>(value as ParseSize); }
        }

        public override string ToString()
        {
            return Size.Name + " (" + Price.ToString("0.00") + " €)";
        }
    }
}
