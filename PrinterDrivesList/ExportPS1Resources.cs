using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterPSTDrivesList
{
    public class ExportPS1Resources
    {
        public ExportPS1Resources()
        {
            //** NOT USED **//
            //** Create outlook_store.ps1 PowerShell script if not in D:\ **//
            string strOutlookPS1 = PrinterPSTDrivesList.Properties.Resources.outlook_store2_ps1;
            string path = @"D:\outlook_store.ps1";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(strOutlookPS1);
                }
            }
        }
    }
}
