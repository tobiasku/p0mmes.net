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
using Parse;
using MetroFramework.Controls;
using System.Collections.ObjectModel;

namespace pOmmes
{
    public partial class FoodDetailUserControl : MetroUserControl
    {
        public ParseArticle article;
        public int quantity = 1;
        public ParseFoodToSize size;
        public Collection<ParseFoodToOption> options = new Collection<ParseFoodToOption>();

        public FoodDetailUserControl(ParseArticle article)
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

        private async void SetFoodDetailSizes()
        {
            mcmb_sizes.DataSource = (await article.GetFoodSizes());
        }

        private async void SetFoodDetailOptions()
        {
            Collection<ParseFoodToOption> options = new Collection<ParseFoodToOption>();

            foreach (ParseFoodToOption option in (await article.GetFoodOptions()))
            {
                if (option.Size == null || option.Size.ObjectId == size.Size.ObjectId)
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
            foreach (ParseFoodToOption option in options)
            {
                price += option.Price;
            }
            price = price * quantity;
            mlbl_price.Text = "Preis: " + price.ToString("0.00") + " €";
        }

        private void mcmb_sizes_SelectedValueChanged(object sender, EventArgs e)
        {
            size = (ParseFoodToSize)mcmb_sizes.SelectedValue;

            SetFoodDetailOptions();
            SetPrice();
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            options.Clear();
            foreach (object selected in clb_Options.CheckedItems)
            {
                ParseFoodToOption option = (ParseFoodToOption)selected;
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
