using pOmmes.Common.Dic;
using pOmmes.Data;
using pOmmes.Data.MongoDB;
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

            MainForm frm = new MainForm();
            Application.Run(frm);
        }
    }
}
