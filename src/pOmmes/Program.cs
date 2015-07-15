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

            Dic.Put<IpOmmesDataBL, pOmmesDataBL>();
            Dic.Put<IpOmmesDataDL, pOmmesDataDL>();

            Restaurant res = new Restaurant();
            res.Name = "DAFABIO";
            res.PhoneNumber = "02563";
            Dic.Get<IpOmmesDataBL>().Post<Restaurant>(new System.Collections.ObjectModel.Collection<Restaurant>() {res});

            System.Collections.ObjectModel.Collection<Restaurant> result = Dic.Get<IpOmmesDataBL>().Get<Restaurant>();

            MainForm frm = new MainForm();
            Application.Run(frm);
        }
    }
}
