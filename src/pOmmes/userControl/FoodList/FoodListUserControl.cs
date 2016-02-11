using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pOmmes.Common;
using MetroFramework.Controls;
using System.Collections.ObjectModel;
using pOmmes.Data;

namespace pOmmes
{
    public partial class FoodListUserControl : MetroUserControl
    {
        Article article;

        public FoodListUserControl(Article article)
        {
            this.article = article;

            InitializeComponent();
        }

        private void FoodListUserControl_Load(object sender, EventArgs e)
        {
            SetFoodListItem();
        }

        private void SetFoodListItem()
        {
            mlbl_name.Text = article.Name;
            mlbl_description.Text = article.Description;
            mlbl_price.Text = "ab " + article.Sizes.Min(x => x.Price).ToString("0.00") + " €";
        }

        private void FoodListUserControl_Click(object sender, EventArgs e)
        {
            FoodDetailUserControl foodDetailUserControl = new FoodDetailUserControl(article);
            foodDetailUserControl.FoodDetailUserControl_Select += FoodDetailUserControl_FoodDetailUserControl_Select;
            EventBus.Instance.PostEvent(new FoodControlChangeEvent(foodDetailUserControl, UserControlChangeState.Push));
        }

        private void FoodDetailUserControl_FoodDetailUserControl_Select(object sender, FoodDetailUserControlEventArgs e)
        {
            ThrowFoodDetailUserControl_Select(e);
        }

        public event EventHandler<FoodDetailUserControlEventArgs> FoodDetailUserControl_Select;

        private void ThrowFoodDetailUserControl_Select(FoodDetailUserControlEventArgs eventArgs)
        {
            if (FoodDetailUserControl_Select != null)
            {
                this.FoodDetailUserControl_Select(this, eventArgs);
            }
        }
    }
}
