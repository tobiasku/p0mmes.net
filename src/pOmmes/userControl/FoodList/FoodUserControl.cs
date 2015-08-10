using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using pOmmes.Common;
using MetroFramework.Controls;
using pOmmes.Data;
using pOmmes.Common.Dic;

namespace pOmmes
{
    public partial class FoodUserControl : MetroUserControl
    {
        Restaurant restaurant;

        public FoodUserControl(Restaurant restaurant)
        {
            this.restaurant = restaurant;
            InitializeComponent();
            EventBus.Instance.Register(this);
        }

        private void FoodUserControl_Load(object sender, EventArgs e)
        {
            FillFoodList();
        }

        private void FillFoodList()
        {
            IpOmmesDataBL pOmmesDataBL = Dic.Get<IpOmmesDataBL>();

            Dictionary<string, object> filter = new Dictionary<string, object>();
            filter.Add("restaurant", restaurant._id);

            Collection<Article> articleCollection = pOmmesDataBL.Get<Article>(filter);

            Dictionary<string, int> locationDic = new Dictionary<string, int>();

            foreach (Article article in articleCollection)
            {
                if (!mtc_FoodList.TabPages.ContainsKey(article.Category._id))
                {
                    locationDic.Add(article.Category._id, 0);
                    mtc_FoodList.TabPages.Add(article.Category._id, article.Category.Name);
                }

                FoodListUserControl contr = new FoodListUserControl(article);
                contr.Location = new Point(0, locationDic[article.Category._id]);
                this.mtc_FoodList.TabPages[article.Category._id].Controls.Add(contr);

                locationDic[article.Category._id] += contr.Size.Height;
            }
        }


        FoodDetailUserControl actualFoodDetailUserControl;
        string actualFoodObject;

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
                this.mtc_FoodList.TabPages[control.article.Category._id].Controls.Add(control);
                control.BringToFront();
                this.actualFoodObject = control.article.Category._id;
                this.actualFoodDetailUserControl = control;
            }
        }

        private void PopUserControl()
        {
            if (actualFoodDetailUserControl != null)
            {
                this.mtc_FoodList.TabPages[actualFoodObject].Controls.Remove(actualFoodDetailUserControl);
            }
            actualFoodDetailUserControl.Dispose();
            actualFoodDetailUserControl = null;
            actualFoodObject = null;
        }
    }
}