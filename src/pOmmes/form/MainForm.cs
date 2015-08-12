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


        private void MainForm_Load(object sender, EventArgs e)
        {
            //if (User.CurrentUser == null)
            //{
            //    this.Hide();

            //    LoginForm loginForm = new LoginForm();
            //    DialogResult result = loginForm.ShowDialog();
            //    switch (result)
            //    {
            //        case DialogResult.OK:
            //            this.Show();
            //            break;
            //        case DialogResult.Cancel:
            //        default:
            //            this.Close();
            //            return;
            //    }
            //}
            //if (User.CurrentUser != null)
            //{
            //    mlink_CurrentUser.Text = "Logged in as " + User.CurrentUser.UserName;


            EventBus.Instance.PostEvent(new UserControlChangeEvent(new RestaurantUserControl(), UserControlChangeState.Push));

            //}





            //ThreadPool.QueueUserWorkItem(new WaitCallback(x =>
            //{
            //    Article article = new Article();
            //    article.Name = "Döner";
            //    article.Description = "mit Fladenbrot, Fleisch, Eisbergsalat, Krautsalat, Tomaten, Weichkäse, Peperoni, Tzatiki oder Salatsauce";
            //    article.Category = new Category() { Name = "Grillgerichte" };

            //    Dictionary<string, object> filter = new Dictionary<string, object>();
            //    filter.Add("_id", "55bf5e25851dfc122c395c82");
            //    article.Restaurant = Dic.Get<IpOmmesDataBL>().Get<Restaurant>(filter).First();

            //    Collection<ArticleToSize> sizes = new Collection<ArticleToSize>();
            //    sizes.Add(new ArticleToSize() { Size = new Common.Size() { Name = "Klein" }, Price = 3.50 });
            //    sizes.Add(new ArticleToSize() { Size = new Common.Size() { Name = "Groß" }, Price = 6.00 });
            //    article.Sizes = sizes;

            //    Collection<ArticleToOption> options = new Collection<ArticleToOption>();
            //    options.Add(new ArticleToOption() { Option = new Option() { Name = "Ananas" }, Price = 3.50 });
            //    article.Options = options;

            //    Dic.Get<IpOmmesDataBL>().Post<Article>(new Collection<Article>() { article });
            //}));

        }

        private void mlink_CurrentUser_Click(object sender, EventArgs e)
        {
            if (User.CurrentUser != null)
            {
                User.Logout(User.CurrentUser);
            }
            if (User.CurrentUser == null)
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
            if (User.CurrentUser != null)
            {
                mlink_CurrentUser.Text = "Logged in as " + User.CurrentUser.UserName;
            }
        }

        private void mlink_CurrentUser_MouseEnter(object sender, EventArgs e)
        {
            if (User.CurrentUser != null)
            {
                mlink_CurrentUser.Text = "Logout " + User.CurrentUser.UserName;
            }
        }

        private void mlink_CurrentUser_MouseLeave(object sender, EventArgs e)
        {
            if (User.CurrentUser != null)
            {
                mlink_CurrentUser.Text = "Logged in as " + User.CurrentUser.UserName;
            }
        }
    }
}
