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
using Parse;

namespace pOmmes
{
    public partial class FoodDetailUserControl : MetroUserControl
    {
        public Article article;
        public Order order;

        public int quantity = 1;
        public ArticleToSize size;

        public Collection<ArticleToOption> shownOptions = new Collection<ArticleToOption>();

        public Collection<ArticleToOption> selectedOptions = new Collection<ArticleToOption>();

        public FoodDetailUserControl(Article article, Order order)
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
            var query = new ParseQuery<ArticleToSize>().WhereEqualTo("article", article);
            IEnumerable<ArticleToSize> sizesCollection = await query.FindAsync();

            mcmb_sizes.DataSource = sizesCollection;
        }

        private async void SetFoodDetailOptions()
        {
            shownOptions.Clear();

            Data.Size articleSize = await size.Size.Query.FirstAsync();

            var query = new ParseQuery<ArticleToOption>().WhereEqualTo("article", article);
            IEnumerable<ArticleToOption> optionCollection = await query.FindAsync();

            foreach (ArticleToOption option in optionCollection)
            {
                Data.Size optionSize = await option.Size.Query.FirstAsync();

                if (optionSize.ObjectId == articleSize.ObjectId)
                {
                    if (!shownOptions.Contains(option))
                    {
                        shownOptions.Add(option);
                    }
                }
            }

            clb_Options.DataSource = null;
            clb_Options.DataSource = shownOptions;
        }

        private void SetPrice()
        {
            double price = size.Price;

            foreach (ArticleToOption option in selectedOptions)
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
            selectedOptions.Clear();

            foreach (object selected in clb_Options.CheckedItems)
            {
                ArticleToOption option = (ArticleToOption)selected;
                selectedOptions.Add(option);
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

        private async void mbtn_order_Click(object sender, EventArgs e)
        {
            OrderPosition orderPosition = new OrderPosition();
            orderPosition.Article.Add(article);
            orderPosition.ExtraInformation = mtxt_ExtraWishes.Text;
            orderPosition.Order.Add(order);
            orderPosition.Quantity = quantity;
            await order.SaveAsync();

            OrderPositionToSize orderSize = new OrderPositionToSize();
            orderSize.Size = size.Size;
            orderSize.Price = size.Price;
            orderSize.OrderPosition.Add(orderPosition);
            await orderSize.SaveAsync();

            foreach (ArticleToOption selectedOption in selectedOptions)
            {
                OrderPositionToOption orderOption = new OrderPositionToOption();
                orderOption.Size = selectedOption.Size;
                orderOption.Option = selectedOption.Option;
                orderOption.Price = selectedOption.Price;
                orderOption.OrderPosition.Add(orderPosition);
                await orderOption.SaveAsync();
            }

            ThrowFoodDetailUserControl_Select(new FoodDetailUserControlEventArgs());
            EventBus.Instance.PostEvent(new FoodDetailChangeEvent(this, UserControlChangeState.Pop));
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
