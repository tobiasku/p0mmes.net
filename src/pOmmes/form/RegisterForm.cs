using MetroFramework;
using MetroFramework.Forms;
using Parse;
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
    public partial class RegisterForm : MetroForm
    {
        public RegisterForm()
        {
            InitializeComponent();

            LoadCompanyComboBox();
        }

        private async void LoadCompanyComboBox()
        {
            var query = new ParseQuery<Company>();
            IEnumerable<Company> companyCollection = await query.FindAsync();

            if (companyCollection != null)
            {
                this.BeginInvoke(new Action(delegate ()
                {
                    mcmb_Company.DataSource = companyCollection.ToList<Company>();
                    mcmb_Company.DisplayMember = "Name";
                }));

            }
        }

        private async void mbtn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(mtxt_UserName.Text) &&
                    !string.IsNullOrEmpty(mtxt_UserName.Text) &&
                    !string.IsNullOrEmpty(mtxt_ForeName.Text) &&
                    !string.IsNullOrEmpty(mtxt_SurName.Text) &&
                    !string.IsNullOrEmpty(mtxt_Email.Text) &&
                    !string.IsNullOrEmpty(mtxt_Password.Text) &&
                    !string.IsNullOrEmpty(mtxt_RetypePassword.Text))
                {
                    ParseUser user = new ParseUser()
                    {
                        Username= mtxt_UserName.Text,
                        Password= mtxt_Password.Text,
                        Email = mtxt_Email.Text,
                    };

                    user["ForeName"] = mtxt_ForeName.Text;
                    user["SurName"] = mtxt_SurName.Text;
                    user.GetRelation<Company>("Company").Add((Company)mcmb_Company.SelectedValue);

                    await user.SignUpAsync();
                    if (ParseUser.CurrentUser != null)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
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
    }
}
