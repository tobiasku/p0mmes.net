using pOmmes.Common;
using pOmmes.Common.Dic;
using pOmmes.Data;
using pOmmes.Data.Mongo;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Dic.Put<IpOmmesDataDL, pOmmesDataDL>();
            Dic.Put<IpOmmesDataBL, pOmmesDataBL>();

            //Event eventObject = new Event();
            //eventObject.Company = new Company() { Name = "Pfreundt GmbH" };
            //eventObject.Name = "EW Event 14.08.2015";
            //eventObject.DateToOrder = DateTime.Now.AddDays(7);
            //eventObject.DateToVote = DateTime.Now.AddDays(6);

            //eventObject.EventState = EventState.Edit;
            //eventObject.EventType = EventType.StaticEvent;



            //Dic.Get<IpOmmesDataBL>().Post<Event>(new Collection<Event> { eventObject });

            MainForm frm = new MainForm();
            Application.Run(frm);
        }
    }
}
