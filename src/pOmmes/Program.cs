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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm frm = new MainForm();

            ParseObject.RegisterSubclass<ParseArticle>();
            ParseObject.RegisterSubclass<ParseFoodToOption>();
            ParseObject.RegisterSubclass<ParseFoodToSize>();
            ParseObject.RegisterSubclass<ParseCategory>();
            ParseObject.RegisterSubclass<ParseCompany>();
            ParseObject.RegisterSubclass<ParseEvent>();
            ParseObject.RegisterSubclass<ParseOption>();
            ParseObject.RegisterSubclass<ParseOrder>();
            ParseObject.RegisterSubclass<ParseOrderPosition>();
            ParseObject.RegisterSubclass<ParseRestaurant>();
            ParseObject.RegisterSubclass<ParseSize>();
            ParseObject.RegisterSubclass<ParseVote>();
            ParseClient.Initialize("gcB3bvLRmFS2uRur2UZKrAvvycyFA59lyrQ7VqZW", "5dXJZXLGYMWs9lv1ZkkdEQZhm8lI42Bt9IjgUyO7");

            Application.Run(frm);
        }
    }
}
