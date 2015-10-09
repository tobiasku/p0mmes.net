using MetroFramework;
using MetroFramework.Forms;
using Parse;
using pOmmes.Common;
using pOmmes.Data;
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
    public partial class ResetPasswordForm : MetroForm
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }


        private void mbtn_ResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(mtxt_Email.Text))
                {
                    ParseUser.RequestPasswordResetAsync(mtxt_Email.Text);
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
    }
}
