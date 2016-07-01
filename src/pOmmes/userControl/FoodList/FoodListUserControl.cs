using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Controls;
using System.Collections.ObjectModel;
using pOmmes.Data;
using Parse;

namespace pOmmes
{
    public partial class FoodListUserControl : MetroUserControl
    {
        Article article;
        Order order;

        public FoodListUserControl(Article article)
        {
            this.article = article;

            InitializeComponent();
        }

        private void FoodListUserControl_Load(object sender, EventArgs e)
        {
            SetFoodListItem();
        }

        private async void SetFoodListItem()
        {
            var query = new ParseQuery<ArticleToSize>().WhereEqualTo("Article", article);
            IEnumerable<ArticleToSize> sizeCollection = await query.FindAsync();

            mlbl_name.Text = article.Name;
            mlbl_description.Text = article.Description;
            mlbl_price.Text = "ab " + sizeCollection.Min(x => x.Price).ToString("0.00") + " €";
        }

        private void FoodListUserControl_Click(object sender, EventArgs e)
        {
            ThrowFoodDetailUserControl_Select(new FoodUserControlEventArgs(article));
        }        

        public event EventHandler<FoodUserControlEventArgs> FoodDetailUserControl_Select;
        private void ThrowFoodDetailUserControl_Select(FoodUserControlEventArgs eventArgs)
        {
            if (FoodDetailUserControl_Select != null)
            {
                this.FoodDetailUserControl_Select(this, eventArgs);
            }
        }
    }
}
