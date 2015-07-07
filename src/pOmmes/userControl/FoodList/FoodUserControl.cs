using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parse;
using System.Collections.ObjectModel;
using pOmmes_Common;
using MetroFramework.Controls;

namespace pOmmes
{
    public partial class FoodUserControl : MetroUserControl
    {
        ParseRestaurant restaurant;

        public FoodUserControl(ParseRestaurant restaurant)
        {
            this.restaurant = restaurant;
            InitializeComponent();
            EventBus.Instance.Register(this);
        }

        private void FoodUserControl_Load(object sender, EventArgs e)
        {
            FillFoodList();
        }

        private async void FillFoodList()
        {
            ParseQuery<ParseArticle> articleQuery = new ParseQuery<ParseArticle>().WhereEqualTo("restaurantId", restaurant);
            Collection<ParseArticle> articleCollection = new Collection<ParseArticle>((await articleQuery.FindAsync()).ToList<ParseArticle>());

            Dictionary<string, int> locationDic = new Dictionary<string, int>();

            foreach (ParseArticle article in articleCollection)
            {
                if (!mtc_FoodList.TabPages.ContainsKey(article.Category.ObjectId))
                {
                    await article.Category.FetchIfNeededAsync();

                    locationDic.Add(article.Category.ObjectId, 0);
                    mtc_FoodList.TabPages.Add(article.Category.ObjectId, article.Category.Name);
                }

                FoodListUserControl contr = new FoodListUserControl(article);
                contr.Location = new Point(0, locationDic[article.Category.ObjectId]);
                this.mtc_FoodList.TabPages[article.Category.ObjectId].Controls.Add(contr);

                locationDic[article.Category.ObjectId] += contr.Size.Height;
            }
        }


        FoodDetailUserControl actualFoodDetailUserControl;
        string actualFoodObjectId;

        public void OnEvent(FoodDetailChangeEvent e)
        {
            switch (e.State)
            {
                case UserControlChangeState.Pop:
                    PopUserControl();
                    break;
                case UserControlChangeState.Push:
                    PushUserControl(e.Control);
                    break;
            }
        }

        private void PushUserControl(FoodDetailUserControl control)
        {
            if (actualFoodDetailUserControl != null)
            {
                PopUserControl();
            }

            if (control != null)
            {
                control.Location = new Point((this.Size.Width / 2 - control.Size.Width / 2), (this.Size.Height / 2 - control.Size.Height / 2));
                this.mtc_FoodList.TabPages[control.article.Category.ObjectId].Controls.Add(control);
                control.BringToFront();
                this.actualFoodObjectId = control.article.Category.ObjectId;
                this.actualFoodDetailUserControl = control;
            }
        }

        private void PopUserControl()
        {
            if (actualFoodDetailUserControl != null)
            {
                this.mtc_FoodList.TabPages[actualFoodObjectId].Controls.Remove(actualFoodDetailUserControl);
            }
            actualFoodDetailUserControl.Dispose();
            actualFoodDetailUserControl = null;
            actualFoodObjectId = null;
        }
    }
}