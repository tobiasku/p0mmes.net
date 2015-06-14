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
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (ParseUser.CurrentUser == null)
            {
                this.Close();
            }
            mlink_CurrentUser.Text = "Logged in as " + ParseUser.CurrentUser.Username;
        }

        private void mlink_CurrentUser_Click(object sender, EventArgs e)
        {
            if (ParseUser.CurrentUser != null)
            {
                ParseUser.LogOut();
            }
        }

        private void mlink_CurrentUser_MouseEnter(object sender, EventArgs e)
        {
            if (ParseUser.CurrentUser != null)
            {
                mlink_CurrentUser.Text = "Logout " + ParseUser.CurrentUser.Username;
            }
        }

        private void mlink_CurrentUser_MouseLeave(object sender, EventArgs e)
        {
            if (ParseUser.CurrentUser != null)
            {
                mlink_CurrentUser.Text = "Logged in as " + ParseUser.CurrentUser.Username;
            }
        }
    }
}
