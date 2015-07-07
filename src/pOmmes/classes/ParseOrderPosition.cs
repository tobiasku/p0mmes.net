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
    [ParseClassName("OrderPosition")]
    public class ParseOrderPosition : ParseObject
    {
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

        [ParseFieldName("extraInformation")]
        public string ExtraInformation
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        public Collection<ParseOption> Options
        {
            get { return null; }
            set { }
        }
    }
}
