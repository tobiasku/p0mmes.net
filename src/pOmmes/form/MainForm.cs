using MetroFramework.Forms;

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
using Parse;

namespace pOmmes
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();

            EventBus.Instance.Register(this);
        }

        Stack<UserControl> userControlBackStack = new Stack<UserControl>();
        System.Windows.Forms.Timer timMouseLocation = new System.Windows.Forms.Timer();

        public void OnEvent(UserControlChangeEvent e)
        {
            switch (e.State)
            {
                case UserControlChangeState.Pop:
                    PopUserControl();
                    break;
                case UserControlChangeState.Push:
                    PushUserControl(e.Control);
                    break;
            }
        }

        private void PushUserControl(UserControl control)
        {
            if (userControlBackStack.Count > 0)
            {
                this.mpnl_Main.Controls.Remove(userControlBackStack.Peek());
            }

            if (control != null)
            {
                this.mpnl_Main.Controls.Add(control);
                this.userControlBackStack.Push(control);
            }
        }

        private void PopUserControl()
        {
            if (userControlBackStack.Count > 0)
            {
                this.mpnl_Main.Controls.Remove(userControlBackStack.Pop());
            }

            if (userControlBackStack.Count > 0)
            {
                this.mpnl_Main.Controls.Add(userControlBackStack.Peek());
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            timMouseLocation.Interval = 50;
            timMouseLocation.Tick += TimMouseLocation_Tick;
            timMouseLocation.Start();

            if (ParseUser.CurrentUser == null)
            {
                this.Hide();

                LoginForm loginForm = new LoginForm();
                DialogResult result = loginForm.ShowDialog();
                switch (result)
                {
                    case DialogResult.OK:
                        this.Show();
                        break;
                    case DialogResult.Cancel:
                    default:
                        this.Close();
                        return;
                }
            }
            if (ParseUser.CurrentUser != null)
            {
                mlink_CurrentUser.Text = "Logged in as " + ParseUser.CurrentUser["username"];

                EventBus.Instance.PostEvent(new UserControlChangeEvent(new EventUserControl(), UserControlChangeState.Push));
            }
        }

        private void TimMouseLocation_Tick(object sender, EventArgs e)
        {
            Point p = this.PointToClient(Cursor.Position);
            if (p.Y > 600)
            {
                mpnlControls.Visible = true;
                this.Size = new System.Drawing.Size(440, 723);
            }
            else
            {
                mpnlControls.Visible = false;
                this.Size = new System.Drawing.Size(440, 674);
            }
        }

        private void mlink_CurrentUser_Click(object sender, EventArgs e)
        {
            if (ParseUser.CurrentUser != null)
            {
                ParseUser.LogOut();
            }
            if (ParseUser.CurrentUser == null)
            {
                this.Hide();

                LoginForm loginForm = new LoginForm();
                DialogResult result = loginForm.ShowDialog();
                switch (result)
                {
                    case DialogResult.OK:
                        this.Show();
                        break;
                    case DialogResult.Cancel:
                    default:
                        this.Close();
                        return;
                }
            }
            if (ParseUser.CurrentUser != null)
            {
                mlink_CurrentUser.Text = "Logged in as " + ParseUser.CurrentUser["username"];
            }
        }

        private void mlink_CurrentUser_MouseEnter(object sender, EventArgs e)
        {
            if (ParseUser.CurrentUser != null)
            {
                mlink_CurrentUser.Text = "Logout " + ParseUser.CurrentUser["username"];
            }
        }

        private void mlink_CurrentUser_MouseLeave(object sender, EventArgs e)
        {
            if (ParseUser.CurrentUser != null)
            {
                mlink_CurrentUser.Text = "Logged in as " + ParseUser.CurrentUser["username"];
            }
        }
        
        private void mpnlMenu_Click(object sender, EventArgs e)
        {
            //TODO Menü als Panel für die entsprechende offene Seite
        }

        private void mpnlHome_Click_1(object sender, EventArgs e)
        {
            for (int i = userControlBackStack.Count; i > 1; i--)
            {
                EventBus.Instance.PostEvent(new UserControlChangeEvent(null, UserControlChangeState.Pop));
            }
        }

        private void mpnlReturn_Click(object sender, EventArgs e)
        {
            if (userControlBackStack.Count > 1)
            {
                EventBus.Instance.PostEvent(new UserControlChangeEvent(null, UserControlChangeState.Pop));
            }
        }

        private void metroPanel1_MouseHover(object sender, EventArgs e)
        {

        }
    }
}