using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrinterPSTDrivesList
{
    public class PrinterName
    {
        public string list;
        public PrinterName()
        {
            list = "________________________________________" + "\r\n";
            list += "Installed Printers" + "\r\n" + "\r\n";

            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                list += printer.ToString() + "\r\n";
            }

            list += "________________________________________" + "\r\n";
            try
            {
                list += "\r\n";
                list += DateTime.Now + "\r\n";
                ProcessStartInfo psi = new ProcessStartInfo("net", "use");
                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;
                psi.CreateNoWindow = true;
                var proc = Process.Start(psi);

                string s = proc.StandardOutput.ReadToEnd();

                list += s + "________________________________________" + "\r\n";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error Processing Net Use Command");
            }
        }

        public override string ToString()
        {
            return list;
        }
    }
}
