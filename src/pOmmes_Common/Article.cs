using Parse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    [ParseClassName("Article")]
    public class Article : ParseObject
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        [ParseFieldName("Name")]
        public string Name
        {
            get;
            set;
        }

        [ParseFieldName("Number")]
        public int Number
        {
            get;
            set;
        }

        [ParseFieldName("Restaurant")]
        public ParseRelation<Restaurant> Restaurant
        {
            set { SetProperty<ParseRelation<Restaurant>>(value); }
            get { return GetRelationProperty<Restaurant>(); }
        }

        [ParseFieldName("Description")]
        public string Description
        {
            get;
            set;
        }

        [ParseFieldName("Category")]
        public ParseRelation<Category> Category
        {
            set { SetProperty<ParseRelation<Category>>(value); }
            get { return GetRelationProperty<Category>(); }
        }
    }
}
