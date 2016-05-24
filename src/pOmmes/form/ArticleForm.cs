using MetroFramework;
using MetroFramework.Forms;
using Parse;
using pOmmes.Common;
using pOmmes.Common;
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

            this.mg_Options_clm_Option.DataSource = optionCollection;
            this.mg_Options_clm_Option.DisplayMember = "Name";

            this.mg_Options_clm_Size.DataSource = sizeCollection;
            this.mg_Options_clm_Size.DisplayMember = "Name";
        }

        private async void LoadSizesGrid()
        {
            IEnumerable<Data.Size> sizeCollection = await new ParseQuery<Data.Size>().FindAsync();

            this.mg_Sizes_clm_Size.DataSource = sizeCollection;
            this.mg_Sizes_clm_Size.DisplayMember = "Name";
        }

        private async void LoadRestaurantComboBox()
        {
            IEnumerable<Restaurant> restaurantCollection = await new ParseQuery<Restaurant>().FindAsync();
            if (restaurantCollection != null)
            {
                this.BeginInvoke(new Action(delegate ()
                {
                    mcmb_Restaurant.DataSource = restaurantCollection;
                    mcmb_Restaurant.DisplayMember = "Name";
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
                    mcmb_Category.DataSource = categoryCollection;
                    mcmb_Category.DisplayMember = "Name";
                }));

            }
        }


        private void mbtn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(mtxt_Name.Text) &&
                    !string.IsNullOrEmpty(mtxt_Name.Text) &&
                    !string.IsNullOrEmpty(mtxt_Description.Text))
                {
                    //User user = new User();

                    //user.UserName = mtxt_Name.Text;
                    //user.Password = mtxt_Password.Text;
                    //user.Email = mtxt_Email.Text;
                    //user.ForeName = mtxt_Description.Text;
                    //user.SurName = mtxt_SurName.Text;
                    //user.Company = (Restaurant)mcmb_Restaurant.SelectedValue;




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

            ArticleToSize articleSize = new ArticleToSize();

            if (e.Row != null)
            {
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)e.Row.Cells["mg_Sizes_clm_Size"];
                if (cell != null)
                {
                    Data.Size size = (Data.Size)cell.Value;
                }
            }
        }

        private void mg_Sizes_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Console.WriteLine("UserDeletedRow");
        }
    }
}
