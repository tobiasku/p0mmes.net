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

namespace pOmmes
{
    public partial class FoodDetailUserControl : MetroUserControl
    {
        public Article article;

        public int quantity = 1;
        public ArticleToSize size;
        public Collection<ArticleToOption> options = new Collection<ArticleToOption>();

        public FoodDetailUserControl(Article article)
        {
            InitializeComponent();
            this.article = article;
        }

        private void FoodDetailUserControl_Load(object sender, EventArgs e)
        {
            SetFoodDetailItem();
            SetFoodDetailSizes();
            SetFoodDetailOptions();
        }

        private void SetFoodDetailItem()
        {
            mlbl_name.Text = article.Name;
            mlbl_description.Text = article.Description;
        }

        private void SetFoodDetailSizes()
        {
            mcmb_sizes.DataSource = article.Sizes;
            mcmb_sizes.DisplayMember = "Size";
        }

        private void SetFoodDetailOptions()
        {
            foreach (ArticleToOption option in article.Options)
            {
                if (option.Size == null || option.Size._id == size._id)
                {
                    if (!options.Contains(option))
                    {
                        options.Add(option);
                    }
                }
            }

            clb_Options.DataSource = options;
            SetPrice();
        }

        private void SetPrice()
        {
            double price = size.Price;

            foreach (ArticleToOption option in options)
            {
                price += option.Price;
            }

            price = price * quantity;
            mlbl_price.Text = "Preis: " + price.ToString("0.00") + " €";
        }

        private void mcmb_sizes_SelectedValueChanged(object sender, EventArgs e)
        {
            size = (ArticleToSize)mcmb_sizes.SelectedValue;

            SetFoodDetailOptions();
            SetPrice();
        }

        private void clb_Options_SelectedValueChanged(object sender, EventArgs e)
        {
            options.Clear();
            foreach (object selected in clb_Options.CheckedItems)
            {
                ArticleToOption option = (ArticleToOption)selected;
                options.Add(option);
            }

            SetPrice();
        }

        private void mtxt_Count_TextChanged(object sender, EventArgs e)
        {
            try
            {
                quantity = int.Parse(mtxt_Count.Text);
                SetPrice();
            }
            catch
            {
            }
        }

        private void mtxt_Count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void mlink_Close_Click(object sender, EventArgs e)
        {
            EventBus.Instance.PostEvent(new FoodDetailChangeEvent(this, UserControlChangeState.Pop));
        }
    }
}
