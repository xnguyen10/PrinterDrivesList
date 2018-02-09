///<summary>
///Upadated Version 2.8.2018
///Siemens PC Migration Tool
///Program to retrieve and export printers, drives, and pst file locations to txt file.
///Also, creates batch file to install previous printers to new pc.
/// </summary>

using System;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Office.Interop.Outlook;

namespace PrinterDrivesList
{

    public partial class frmPrintMap : Form
    {
        public frmPrintMap()
        {
            InitializeComponent();
        }

        PrinterPSTDrivesList.PrinterName pn;
        PrinterPSTDrivesList.ListPST listpst;

        public void frmPrintMap_Load(object sender, EventArgs e)
        {
            string strUserName = Environment.UserName;
            txtUserName.Text = strUserName;
            txtDrivesNPrinters.Text = strUserName + " - " + DateTime.Now + "\r\n";
        }

        public void RetrieveData_Click(object sender, EventArgs e)
        {
            pn = new PrinterPSTDrivesList.PrinterName();
            listpst = new PrinterPSTDrivesList.ListPST();

            txtDrivesNPrinters.Text += pn.ToString();
            txtDrivesNPrinters.Text += listpst.ToString();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File | *.txt";
            sfd.Title = "Save To Text File";
            sfd.FileName = txtUserName.Text;

            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string name = sfd.FileName;
                File.WriteAllText(name, txtDrivesNPrinters.Text);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnCreatePrintBat_Click(object sender, EventArgs e)
        {
            //** Find Username and diplay in textBox
            string strUserName = Environment.UserName;

            txtDrivesNPrinters.Text = "";

            string strServerName = "";

            if (rdoHouston.Checked)
            {
                strServerName = "ushouamw6145srv.na.d-rco.com";

                //** Import printers.txt from Resources to variable strPrinterList
                string strPrinterList = PrinterPSTDrivesList.Properties.Resources.printers;

                //** Look for Installed Printers and write to textBox
                foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    string trimInstalledPrinter = printer.Substring(printer.LastIndexOf("\\") + 1);
                    txtDrivesNPrinters.Text += trimInstalledPrinter.ToUpper() + "\r\n";
                }

                //** Restrieve Printer from printers.txt list from string strPrinterList
                string[] arrPrintersListHOU = strPrinterList.Split(';');

                //** Create Batch file from txtDrivesNPrinters TextBox
                txtPrintBatch.Text = "@echo Mapping Network Printers for User" + "\r\n";

                foreach (string line in txtDrivesNPrinters.Lines)
                {
                    //** Trim \\USHOUAMW6145WRV\ or it will not equal
                    string trimPrinter = line.Substring(line.LastIndexOf("\\") + 1);
                    //string strServerName = "test";

                    foreach (string printer in arrPrintersListHOU)
                        //line is list of mapped printers, printer is list of printers on printers.txt
                        if (line.Equals(printer))
                        {
                            string PrintBatch = "start " + "\\" + "\\" + strServerName + "\\" + trimPrinter + "\r\n" + "pause" + "\r\n";
                            txtPrintBatch.Text += PrintBatch;
                        }
                }
                txtUserName.Text = strUserName + "_PrinterBatchHOU";
            }
            else if (rdoOlean.Checked)
            {
                strServerName = "usoancw029srv.ad001.siemens.net";
                string strPrinterListOlean = PrinterPSTDrivesList.Properties.Resources.OleanPrintersOLD2;
                string strPrinterListOlean2 = PrinterPSTDrivesList.Properties.Resources.OleanPrintersNEW2;

                foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    string trimInstalledPrinter = printer.Substring(printer.LastIndexOf("\\") + 1);
                    txtDrivesNPrinters.Text += trimInstalledPrinter.ToUpper() + "\r\n";
                }

                string[] arrPrintersListOlean = strPrinterListOlean.Split(',');
                string[] arrPrintersListOlean2 = strPrinterListOlean2.Split(',');

                for (int i = 0; i < arrPrintersListOlean.Length; i++)
                {
                    foreach (string installedPrinters in txtDrivesNPrinters.Lines)
                        if (installedPrinters == arrPrintersListOlean[i])
                        {
                            string PrintBatch = "start " + "\\" + "\\" + strServerName + "\\" + arrPrintersListOlean2[i] + "\r\n" + "pause" + "\r\n";
                            txtPrintBatch.Text += PrintBatch;
                        }
                }
                txtUserName.Text = strUserName + "_PrinterBatchOlean";
            }
            else if (rdoPPT.Checked)
            {
                strServerName = "drpptw03.na.d-rco.com";

                string strPrinterListPPT = PrinterPSTDrivesList.Properties.Resources.printersPPT;

                //** Look for Installed Printers and write to textBox
                foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    //** Trim all characters from '\\' to left end AND convert all char UpperCase
                    string trimInstalledPrinter = printer.Substring(printer.LastIndexOf("\\") + 1);
                    txtDrivesNPrinters.Text += trimInstalledPrinter.ToUpper() + "\r\n";
                }

                //** Restrieve Printer from printersOlean.txt list from string strPrinterListOlean
                string[] arrPrintersListPPT = strPrinterListPPT.Split(';');

                //** Create Batch file from txtDrivesNPrinters TextBox
                txtPrintBatch.Text = "@echo Mapping Network Printers for User" + "\r\n";

                foreach (string line in txtDrivesNPrinters.Lines)
                {
                    //** Trim \\USHOUAMW6145WRV\ or it will not equal ** NOT Need this trim.  Already done above.
                    string trimPrinter = line.Substring(line.LastIndexOf("\\") + 1);
                    //string strServerName = "test";

                    foreach (string printer in arrPrintersListPPT)
                        //line is list of mapped printers, printer is list of printers on printers.txt
                        if (line.Equals(printer))
                        {
                            //MessageBox.Show("\\" + "\\" + "ushouamw6145srv.na.d-rco.com" + "\\" + line);
                            string PrintBatch = "start " + "\\" + "\\" + strServerName + "\\" + trimPrinter + "\r\n" + "pause" + "\r\n";
                            txtPrintBatch.Text += PrintBatch;
                        }
                }
                txtUserName.Text = strUserName + "_PrinterBatchPPT";
            }

            //** Export to Batch file//
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File | *.bat";
            sfd.Title = "Save as Batch File";
            sfd.FileName = txtUserName.Text;

            //** Save As Dialog Box to location
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string name = sfd.FileName;
                File.WriteAllText(name, txtPrintBatch.Text);
            }
        }


        //private string ToString(object printers)
        //{
        //    throw new NotImplementedException();
        //}

        //public static void CopyStream(Stream input, Stream output)
        //{
        //    // Insert null checking here for production
        //    byte[] buffer = new byte[8192];

        //    int bytesRead;
        //    while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
        //    {
        //        output.Write(buffer, 0, bytesRead);
        //    }
        //}


        //static string ConvertStringArrayToString(string[] array)
        //{
        //    StringBuilder builder = new StringBuilder();
        //    foreach (string value in array)
        //    {
        //        builder.Append(value);
        //        builder.Append('.');
        //    }
        //    return builder.ToString();
        //}
    }
}
