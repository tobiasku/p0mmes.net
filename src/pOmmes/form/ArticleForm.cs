using MetroFramework;
using MetroFramework.Forms;
using pOmmes.Common;
using pOmmes.Common.Dic;
using pOmmes.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pOmmes
{
    public partial class ArticleForm : MetroForm
    {
        private Article article;

        public ArticleForm(Article article)
        {
            if (article == null)
            {
                this.article = new Article();
            }
            else
            {
                this.article = article;
            }

            InitializeComponent();

            LoadSizesGrid();
            LoadOptionsGrid();

            LoadRestaurantComboBox();
            LoadCategoryComboBox();
        }

        private void LoadOptionsGrid()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(x =>
            {
                //Data.Size size = new Data.Size();
                //size.Name = "Klein";
                //size.Post();

                //Data.Size size2 = new Data.Size();
                //size2.Name = "Groß";
                //size2.Post();

                //Option option = new Option();
                //option.Name = "Dönerfleisch";
                //option.Post();

                //Option option2 = new Option();
                //option2.Name = "Tzatziki";
                //option2.Post();

                //Option option3 = new Option();
                //option3.Name = "Tomaten";
                //option3.Post();

                Collection<pOmmes.Data.Size> sizeCollection = pOmmes.Data.Size.Get();
                Collection<Option> optionCollection = pOmmes.Data.Option.Get();

                this.mg_Options_clm_Option.DataSource = optionCollection;
                this.mg_Options_clm_Option.DisplayMember = "Name";

                this.mg_Options_clm_Size.DataSource = sizeCollection;
                this.mg_Options_clm_Size.DisplayMember = "Name";
            }));
        }

        private void LoadSizesGrid()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(x =>
            {
                Collection<pOmmes.Data.Size> sizeCollection = pOmmes.Data.Size.Get();
                Collection<pOmmes.Data.Size> articleSizes = new Collection<pOmmes.Data.Size>();
                
                foreach (ArticleToSize sizeValue in article.Sizes)
                {
                    articleSizes.Add(sizeValue.Size);
                    this.mg_Sizes.Rows.Add(new object[] { sizeValue.Size, sizeValue.Price });
                }

                List<pOmmes.Data.Size> result = sizeCollection.Except(articleSizes).ToList<Data.Size>();

                this.mg_Sizes_clm_Size.DataSource = result;
                this.mg_Sizes_clm_Size.DisplayMember = "Name";
            }));
        }

        private void LoadRestaurantComboBox()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(x =>
            {
                Collection<Restaurant> restaurantCollection = Restaurant.Get();
                if (restaurantCollection != null)
                {
                    this.BeginInvoke(new Action(delegate ()
                    {
                        mcmb_Restaurant.DataSource = restaurantCollection;
                        mcmb_Restaurant.DisplayMember = "Name";
                    }));

                }
            }));
        }

        private void LoadCategoryComboBox()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(x =>
            {
                Collection<Category> categoryCollection = Category.Get();
                if (categoryCollection != null)
                {
                    this.BeginInvoke(new Action(delegate ()
                    {
                        mcmb_Category.DataSource = categoryCollection;
                        mcmb_Category.DisplayMember = "Name";
                    }));

                }
            }));
        }


        private void mbtn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(mtxt_Name.Text) &&
                    !string.IsNullOrEmpty(mtxt_Name.Text) &&
                    !string.IsNullOrEmpty(mtxt_Description.Text))
                {
                    article.Name = mtxt_Name.Text;
                    article.Number = mtxt_Number.Text;
                    article.Description = mtxt_Description.Text;
                    article.Category = (Category)mcmb_Category.SelectedValue;
                    article.Restaurant = (Restaurant)mcmb_Restaurant.SelectedValue;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MetroMessageBox.Show(this, "Fill all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mbtn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void mg_Sizes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("CellValueChanged");
        }

        private void mg_Sizes_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            Console.WriteLine("UserAddedRow");

            if (e.Row != null)
            {
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)e.Row.Cells[0];
                pOmmes.Data.Size selectedSizeValue = (pOmmes.Data.Size)cell.Value;

                double priceValue = 0.0;
                try
                {
                    priceValue = Convert.ToDouble(((DataGridViewTextBoxCell)e.Row.Cells[1]).Value);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ArticleToSize articleSize = article.Sizes.FirstOrDefault(x => x.Size == selectedSizeValue);

                if (articleSize != null)
                {
                    articleSize.Price = priceValue;
                    articleSize.Put();
                }
                else
                {
                    ArticleToSize newArticleSize = new ArticleToSize();
                    newArticleSize.Size = selectedSizeValue;
                    newArticleSize.Price = priceValue;
                    newArticleSize.Post();

                    article.Sizes.Add(newArticleSize);
                }

                LoadSizesGrid();
            }
        }

        private void mg_Sizes_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Console.WriteLine("UserDeletedRow");
        }
    }
}
