using MetroFramework;
using MetroFramework.Forms;
using Parse;
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
                article = new Article();
            }

            this.article = article;

            InitializeComponent();

            LoadSizesGrid();
            LoadOptionsGrid();

            LoadRestaurantComboBox();
            LoadCategoryComboBox();
        }

        private async void LoadOptionsGrid()
        {
            IEnumerable<Data.Size> sizeCollection = await new ParseQuery<Data.Size>().FindAsync();
            IEnumerable<Data.Option> optionCollection = await new ParseQuery<Data.Option>().FindAsync();
            if (sizeCollection != null && optionCollection != null)
            {
                this.BeginInvoke(new Action(delegate ()
                {
                    this.mg_Options_clm_Option.DisplayMember = "Name";
                    this.mg_Options_clm_Option.ValueMember = "ObjectId";
                    this.mg_Options_clm_Option.DataSource = optionCollection.ToList();

                    this.mg_Options_clm_Size.DisplayMember = "Name";
                    this.mg_Options_clm_Size.ValueMember = "ObjectId";
                    this.mg_Options_clm_Size.DataSource = sizeCollection.ToList();
                }));
            }
        }

        private async void LoadSizesGrid()
        {
            IEnumerable<Data.Size> sizeCollection = await new ParseQuery<Data.Size>().FindAsync();
            if (sizeCollection != null)
            {
                this.BeginInvoke(new Action(delegate ()
                {
                    this.mg_Sizes_clm_Size.DisplayMember = "Name";
                    this.mg_Sizes_clm_Size.ValueMember = "ObjectId";
                    this.mg_Sizes_clm_Size.DataSource = sizeCollection.ToList();
                }));
            }
        }

        private async void LoadRestaurantComboBox()
        {
            IEnumerable<Restaurant> restaurantCollection = await new ParseQuery<Restaurant>().FindAsync();
            if (restaurantCollection != null)
            {
                this.BeginInvoke(new Action(delegate ()
                {
                    this.mcmb_Restaurant.DisplayMember = "Name";
                    this.mcmb_Restaurant.ValueMember = "ObjectId";
                    this.mcmb_Restaurant.DataSource = restaurantCollection.ToList();
                }));

            }
        }

        private async void LoadCategoryComboBox()
        {
            IEnumerable<Category> categoryCollection = await new ParseQuery<Category>().FindAsync();
            if (categoryCollection != null)
            {
                this.BeginInvoke(new Action(delegate ()
                {
                    this.mcmb_Category.DisplayMember = "Name";
                    this.mcmb_Category.ValueMember = "ObjectId";
                    this.mcmb_Category.DataSource = categoryCollection.ToList();
                }));

            }
        }


        private void mbtn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(mtxt_Name.Text) &&
                    !string.IsNullOrEmpty(mtxt_Number.Text) &&
                    !string.IsNullOrEmpty(mtxt_Description.Text))
                {
                    article.Name = mtxt_Name.Text;
                    article.Number = mtxt_Number.Text;
                    article.Description = mtxt_Description.Text;

                    Restaurant restaurant = ParseObject.CreateWithoutData<Restaurant>(mcmb_Restaurant.SelectedValue.ToString());
                    if (restaurant != null)
                    {
                        article.Restaurant = restaurant;
                    }

                    Category category = ParseObject.CreateWithoutData<Category>(mcmb_Category.SelectedValue.ToString());
                    if (category != null)
                    {
                        article.Category = category;
                    }

                    article.SaveAsync();


                    foreach (DataGridViewRow row in mg_Sizes.Rows)
                    {
                        ArticleToSize size = new ArticleToSize();
                        size.Article = article;
                        size.Price = Convert.ToDouble(row.Cells["mg_Sizes_txt_Price"].Value);
                        size.Size = ParseObject.CreateWithoutData<Data.Size>(row.Cells["mg_Sizes_clm_Size"].Value.ToString());
                        size.SaveAsync();
                    }

                    foreach (DataGridViewRow row in mg_Options.Rows)
                    {
                        ArticleToOption option= new ArticleToOption();
                        option.Article = article;
                        option.Price = Convert.ToDouble(row.Cells["mg_Options_txt_Price"].Value);
                        option.Size = ParseObject.CreateWithoutData<Data.Size>(row.Cells["mg_Options_clm_Size"].Value.ToString());
                        option.Option = ParseObject.CreateWithoutData<Data.Option>(row.Cells["mg_Options_clm_Option"].Value.ToString());
                        option.SaveAsync();
                    }
                    
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

        //private void mg_Sizes_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        //{
        //    Console.WriteLine("UserAddedRow");

        //    ArticleToSize articleSize = new ArticleToSize();

        //    if (e.Row != null)
        //    {
        //        DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)e.Row.Cells["mg_Sizes_clm_Size"];
        //        if (cell != null)
        //        {
        //            Data.Size size = (Data.Size)cell.Value;
        //        }
        //    }
        //}
    }
}
