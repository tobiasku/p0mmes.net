using MetroFramework.Forms;
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
        

        private async void MainForm_Load(object sender, EventArgs e)
        {
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
                var query = new ParseQuery<Event>();
                IEnumerable<Event> eventCollection = await query.FindAsync();


                mlink_CurrentUser.Text = "Logged in as " + ParseUser.CurrentUser["username"];

                EventBus.Instance.PostEvent(new UserControlChangeEvent(new EventUserControl(), UserControlChangeState.Push));
            }
        }

        private void RestaurantControl_RestaurantUserControl_Select(object sender, RestaurantUserControlEventArgs e)
        {
            EventBus.Instance.PostEvent(new UserControlChangeEvent(new FoodUserControl(e.Event), UserControlChangeState.Push));
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
    }
}
