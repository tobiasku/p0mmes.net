using MetroFramework;
using MetroFramework.Forms;
using Parse;
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

        private void LoadCompanyComboBox()
        {
            Company.Query(new State(
                new WaitCallback(x =>
                {
                    State state = x as State;
                    if (state != null)
                    {
                        Collection<Company> collection = state.Data as Collection<Company>;
                        if (collection != null)
                        {
                            this.BeginInvoke(new Action(delegate()
                            {
                                mcmb_Company.DataSource = collection;
                                mcmb_Company.DisplayMember = "Name";
                                //mcmb_Company.ValueMember = "ObjectId";
                            }));

                        }
                    }
                }),
                new WaitCallback(x =>
                {
                })
            ));
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
                    var user = new ParseUser()
                    {
                        Username = mtxt_UserName.Text,
                        Password = mtxt_Password.Text,
                        Email = mtxt_Email.Text
                    };

                    // other fields can be set just like with ParseObject
                    user["ForeName"] = mtxt_ForeName.Text;
                    user["SurName"] = mtxt_SurName.Text;
                    user["CompanyId"] = mcmb_Company.SelectedValue;

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
