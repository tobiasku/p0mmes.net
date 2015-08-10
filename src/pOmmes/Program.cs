using pOmmes.Common;
using pOmmes.Common.Dic;
using pOmmes.Data;
using pOmmes.Data.Mongo;
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
            
            Dic.Put<IpOmmesDataDL, pOmmesDataDL>();
            Dic.Put<IpOmmesDataBL, pOmmesDataBL>();
                        
            //Restaurant res = new Restaurant();
            //res.Name = "DAFABIO";
            //res.PhoneNumber = "02563";
            //Dic.Get<IpOmmesDataBL>().Post<Restaurant>(new System.Collections.ObjectModel.Collection<Restaurant>() { res });

            //Article res = new Article();
            //res.Name = "Pizza Diavolo";
            //res.Category = new Category() { Name = "Pizza" };
            //res.Description = "Pizza mit Zeug";
            //res.Number = 50;
            //res.Options = new System.Collections.ObjectModel.Collection<Tuple<Option, Size, double>>();
            //res.Restaurant = new Restaurant() { Name = "ToDelete", PhoneNumber = "BlaBla" };
            //Dic.Get<IpOmmesDataBL>().Post<Article>(new System.Collections.ObjectModel.Collection<Article>() { res });

            //System.Collections.ObjectModel.Collection<Restaurant> result1 = Dic.Get<IpOmmesDataBL>().Get<Restaurant>();

            System.Collections.ObjectModel.Collection<Article> result2 = Dic.Get<IpOmmesDataBL>().Get<Article>();

            MainForm frm = new MainForm();
            Application.Run(frm);
        }
    }
}
