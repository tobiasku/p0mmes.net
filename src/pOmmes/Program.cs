using Parse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pOmmes
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ParseObject.RegisterSubclass<Company>();
            ParseClient.Initialize("gcB3bvLRmFS2uRur2UZKrAvvycyFA59lyrQ7VqZW", "5dXJZXLGYMWs9lv1ZkkdEQZhm8lI42Bt9IjgUyO7");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (ParseUser.CurrentUser == null)
            {
                LoginForm loginForm = new LoginForm();
                DialogResult result = loginForm.ShowDialog();
                switch (result)
                {
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
                    default:
                        return;
                }
            }

            if (ParseUser.CurrentUser != null)
            {
                MainForm frm =  new MainForm();
                Application.Run(frm);
            }
        }
    }
}
