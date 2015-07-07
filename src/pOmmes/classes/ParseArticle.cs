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
    [ParseClassName("Food")]
    public class ParseArticle : ParseObject
    {
        [ParseFieldName("name")]
        public string Name
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("description")]
        public string Description
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("number")]
        public int Number
        {
            get { return GetProperty<int>(); }
            set { SetProperty<int>(value); }
        }

        [ParseFieldName("categoryId")]
        public ParseCategory Category
        {
            get { return (ParseCategory)this["categoryId"]; }
            set { SetProperty<ParseCategory>(value as ParseCategory); }
        }

        [ParseFieldName("restaurantId")]
        public ParseRestaurant Restaurant
        {
            get { return (ParseRestaurant)this["restaurantId"]; }
            set { SetProperty<ParseRestaurant>(value as ParseRestaurant); }
        }

        public async Task<Collection<ParseFoodToSize>> GetFoodSizes()
        {
            ParseQuery<ParseFoodToSize> sizeQuery = new ParseQuery<ParseFoodToSize>().WhereEqualTo("foodId", this);
            Collection<ParseFoodToSize> sizeCollection = new Collection<ParseFoodToSize>((await sizeQuery.FindAsync()).ToList<ParseFoodToSize>());

            foreach (ParseFoodToSize sizeObject in sizeCollection)
            {
                await sizeObject.Size.FetchIfNeededAsync();
            }
            return sizeCollection;
        }

        public async Task<Collection<ParseFoodToOption>> GetFoodOptions()
        {
            ParseQuery<ParseFoodToOption> optionQuery = new ParseQuery<ParseFoodToOption>().WhereEqualTo("foodId", this).Or<ParseFoodToOption>(new ParseQuery<ParseFoodToOption>().WhereEqualTo("restaurantId", this.Restaurant));
            Collection<ParseFoodToOption> optionCollection = new Collection<ParseFoodToOption>((await optionQuery.FindAsync()).ToList<ParseFoodToOption>());

            foreach (ParseFoodToOption optionObject in optionCollection)
            {
                if (optionObject.Size != null)
                {
                    await optionObject.Size.FetchIfNeededAsync();
                }
                if (optionObject.Option != null)
                {
                    await optionObject.Option.FetchIfNeededAsync();
                }
            }
            return optionCollection;
        }
    }
}
