using Parse;
using pOmmes.Common;
using pOmmes.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            #region PARSE
            ParseObject.RegisterSubclass<Vote>();
            ParseObject.RegisterSubclass<Size>();
            ParseObject.RegisterSubclass<Restaurant>();
            ParseObject.RegisterSubclass<OrderPosition>();
            ParseObject.RegisterSubclass<OrderPositionToSize>();
            ParseObject.RegisterSubclass<OrderPositionToOption>();
            ParseObject.RegisterSubclass<Order>();
            ParseObject.RegisterSubclass<Option>();
            ParseObject.RegisterSubclass<Event>();
            ParseObject.RegisterSubclass<Company>();
            ParseObject.RegisterSubclass<Category>();
            ParseObject.RegisterSubclass<ArticleToSize>();
            ParseObject.RegisterSubclass<ArticleToOption>();
            ParseObject.RegisterSubclass<Article>();

            ParseClient.Initialize(new ParseClient.Configuration
            {
                ApplicationId = "gcB3bvLRmFS2uRur2UZKrAvvycyFA59lyrQ7VqZW",
                /*Server = "http://p0mmes.herokuapp.com/api/",*/
                Server = "http://localhost:1337/api/",
            });
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm frm = new MainForm();
            frm.ShowDialog();
        }
    }
}
