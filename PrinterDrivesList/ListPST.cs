using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrinterPSTDrivesList
{
    public class ListPST
    {
        public string lstpst;

        public ListPST()
        {
            Microsoft.Office.Interop.Outlook.Application outlookapp = new Microsoft.Office.Interop.Outlook.Application();
            NameSpace ns = outlookapp.Session;
            Stores store = ns.Stores;
            lstpst += "\r\n";
            lstpst += DateTime.Now + "\r\n" + "PST Files" + "\r\n" + "\r\n";
            try
            {
                foreach (Store a in store)
                {
                    switch (a.ExchangeStoreType.ToString())
                    {
                        case "olNotExchange":
                            lstpst += "*" + (a.DisplayName).ToUpper() + "     " + a.FilePath + "\r\n";
                            break;
                    }
                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error Processing Outlook PST sequence");
            }
            lstpst += "________________________________________" + "\r\n";
        }

        public override string ToString()
        {
            return lstpst;
        }
    }
}
