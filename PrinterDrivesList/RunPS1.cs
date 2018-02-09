using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterPSTDrivesList
{
    public class RunPS1
    {
        public string lines;
        public RunPS1()
        {
            //**  TESTING NOT USED  **// .. Testing export and run ps1 file stored in Resources.

            string strCmdText;
            string arg2;
            strCmdText = "d:\\temp\\outlook_store.ps1";
            arg2 = "-executionpolicy bypass";

            lines = "\r\n";
            lines += DateTime.Now + "\r\n";

            ProcessStartInfo psi = new ProcessStartInfo("C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe", arg2 + " " + strCmdText);
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;
            var proc = Process.Start(psi);

            string PSTOutput = proc.StandardOutput.ReadToEnd();

            lines += PSTOutput + "________________________________________" + "\r\n";
        }

        public override string ToString()
        {
            return lines;
        }
    }
}
