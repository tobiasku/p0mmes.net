using MetroFramework;
using MetroFramework.Forms;
using Parse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pOmmes
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void mbtn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(mtxt_Password.Text) && !string.IsNullOrEmpty(mtxt_UserName.Text))
                {
                    await ParseUser.LogInAsync(mtxt_UserName.Text, mtxt_Password.Text);
                    if (ParseUser.CurrentUser != null)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    // Login was successful.
                }
                else
                {
                    MetroMessageBox.Show(this, "Fill all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // The login failed. Check the error to see why.
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mbtn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void mlink_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm frm = new RegisterForm();
            DialogResult result = frm.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    if (ParseUser.CurrentUser != null)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    break;
                default:
                case DialogResult.Cancel:
                    this.Show();
                    break;
            }
        }

        private void mlink_ForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetPasswordForm frm = new ResetPasswordForm();
            frm.ShowDialog();
            this.Show();
        }
    }
}
