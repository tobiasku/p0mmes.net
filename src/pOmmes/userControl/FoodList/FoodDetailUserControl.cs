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
            this.article = article;
            InitializeComponent();
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
            var query = new ParseQuery<ArticleToSize>().WhereEqualTo("Article", article);
            IEnumerable<ArticleToSize> sizes = await query.FindAsync();

            List<ArticleToSize> sizesList = sizes.ToList();

            for (int i = 0; i < sizesList.Count(); i++)
            {
                await sizesList[i].Size.FetchIfNeededAsync();
            }

            if (sizesList != null)
            {
                mcmb_sizes.ValueMember = "ObjectId";
                mcmb_sizes.DisplayMember = "";
                mcmb_sizes.DataSource = sizesList;
                mcmb_sizes.SelectedIndex = 0;
            }
        }

        private async void SetFoodDetailOptions()
        {
            shownOptions.Clear();

            Data.Size articleSize = null;
            try
            {
                if (size != null && size.Size != null)
                {
                    articleSize = await size.Size.FetchAsync();
                }
            }
            catch (ParseException e)
            {

            }

            if (articleSize != null)
            {
                var query = new ParseQuery<ArticleToOption>().WhereEqualTo("Article", article);
                IEnumerable<ArticleToOption> optionCollection = await query.FindAsync();

                foreach (ArticleToOption articleOption in optionCollection)
                {
                    await articleOption.Option.FetchIfNeededAsync();
                    await articleOption.Size.FetchIfNeededAsync();

                    if (articleOption.Size.ObjectId == articleSize.ObjectId)
                    {
                        if (!shownOptions.Contains(articleOption))
                        {
                            await articleOption.FetchIfNeededAsync();
                            shownOptions.Add(articleOption);
                        }
                    }
                }

                clb_Options.DataSource = shownOptions;
            }
        }


        private async void mcmb_sizes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (mcmb_sizes.SelectedValue != null)
            {
                size = ParseObject.CreateWithoutData<ArticleToSize>(mcmb_sizes.SelectedValue.ToString());
                await size.FetchIfNeededAsync();
                await size.Size.FetchIfNeededAsync();

                SetFoodDetailOptions();
                SetPrice();
            }
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

        private void SetPrice()
        {
            if (size != null)
            {
                double price = size.Price;

                foreach (ArticleToOption option in selectedOptions)
                {
                    price += option.Price;
                }

                price = price * quantity;
                mlbl_price.Text = "Preis: " + price.ToString("0.00") + " €";
            }
        }


        private void mlink_Close_Click(object sender, EventArgs e)
        {
            EventBus.Instance.PostEvent(new FoodControlChangeEvent(this, UserControlChangeState.Pop));
        }

        private async void mbtn_order_Click(object sender, EventArgs e)
        {
            OrderPosition orderPosition = new OrderPosition();
            orderPosition.Article = article;
            orderPosition.ExtraInformation = mtxt_ExtraWishes.Text;
            orderPosition.Order = order;
            orderPosition.Quantity = quantity;
            await order.SaveAsync();

            OrderPositionToSize orderSize = new OrderPositionToSize();
            orderSize.Size = size.Size;
            orderSize.Price = size.Price;
            orderSize.OrderPosition = orderPosition;
            await orderSize.SaveAsync();

            foreach (ArticleToOption selectedOption in selectedOptions)
            {
                OrderPositionToOption orderOption = new OrderPositionToOption();
                orderOption.Size = selectedOption.Size;
                orderOption.Option = selectedOption.Option;
                orderOption.Price = selectedOption.Price;
                orderOption.OrderPosition = orderPosition;
                await orderOption.SaveAsync();
            }

            ThrowFoodDetailUserControl_Select(new FoodDetailUserControlEventArgs());
            EventBus.Instance.PostEvent(new FoodControlChangeEvent(this, UserControlChangeState.Pop));
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
