using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pOmmes_Common;
using MetroFramework.Controls;
using System.Collections.ObjectModel;

namespace pOmmes
{
    public partial class FoodListUserControl : MetroUserControl
    {
        ParseArticle article;

        public FoodListUserControl(ParseArticle article)
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
            mlbl_name.Text = article.Name;
            mlbl_description.Text = article.Description;
        }

        private void FoodListUserControl_Click(object sender, EventArgs e)
        {
            EventBus.Instance.PostEvent(new FoodDetailChangeEvent(new FoodDetailUserControl(article), UserControlChangeState.Push));
        }
    }
}
