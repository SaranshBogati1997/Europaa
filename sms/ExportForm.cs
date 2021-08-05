using Lib;
using Lib.Models;
using Lib.Service;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class ExportForm : Form
    {
        
        PurchaseReportModel purchaseReportParameter;
        public bool fileCreated = false;
        string enviroment;
        string projectDirectory;
        string reportDirectory = Directory.GetCurrentDirectory() + "\\Report\\";
        private SalesReportModel salesReportParameter;
        private FinalReportModel finalReportParameter;
        private ReportMode mode;
        private string myDocumentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string moduleName = "EXPORTFORM";
        string jsonInvoiceString = "";
        int creatorId = 0;
        string billNumber = "";
        private int partyId;
        IExportService _exportService;

        public ExportForm(PurchaseReportModel reportParameter, string invoiceJson, string billNo, int supplierId)
        {
            try
            {
                InitializeComponent();
                _exportService = new ExportRepository();
                purchaseReportParameter = reportParameter;
                if (Directory.Exists(myDocumentPath + "\\SMS\\Export") == false)
                {
                    Directory.CreateDirectory(myDocumentPath + "\\SMS\\Export");
                    Directory.CreateDirectory(myDocumentPath + "\\SMS\\Export\\Sales");
                    Directory.CreateDirectory(myDocumentPath + "\\SMS\\Export\\Purchase");
                }
                projectDirectory = myDocumentPath + "\\SMS\\Export\\Purchase\\";
                mainForm.currentUser = new UserModel()
                {
                    UserId = 0
                };
                creatorId = mainForm.currentUser.UserId;
                mode = ReportMode.PURCHASE;
                jsonInvoiceString = invoiceJson;
                billNumber = billNo;
                partyId = supplierId;
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }
        }
        public ExportForm(SalesReportModel reportParameters, string inputJson, string billNo, int customerId)
        {
            try
            {
                InitializeComponent();
                _exportService = new ExportRepository();


                if (Directory.Exists(myDocumentPath + "\\SMS\\Export") == false)
                {
                    Directory.CreateDirectory(myDocumentPath + "\\SMS\\Export");
                    Directory.CreateDirectory(myDocumentPath + "\\SMS\\Export\\Sales");
                    Directory.CreateDirectory(myDocumentPath + "\\SMS\\Export\\Purchase");
                }
                projectDirectory = myDocumentPath + "\\SMS\\Export\\Sales\\";
                this.salesReportParameter = reportParameters;
                mode = ReportMode.SALES;
                jsonInvoiceString = inputJson;
                billNumber = billNo;
                partyId = customerId;
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }
        }
        //public ExportForm(LedgerReportModel reportParameters, string jsonInput)
        //{
        //    try
        //    {
        //        InitializeComponent();

               
        //        if (Directory.Exists(myDocumentPath + "\\SMS\\Export\\Ledger") == false)
        //        {
        //            Directory.CreateDirectory(myDocumentPath + "\\SMS\\Export\\Ledger");
        //        }
        //        projectDirectory = myDocumentPath + "\\SMS\\Export\\Ledger\\";
        //        this.ledgerReportParameter = reportParameters;
        //        mode = ReportMode.LEDGER;
        //        jsonInvoiceString = jsonInput;
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
        //    }
        //}
        public ExportForm(FinalReportModel parameters)
        {
            try
            {
                InitializeComponent();
                _exportService = new ExportRepository();

                enviroment = System.Environment.CurrentDirectory;
                if (Directory.Exists(myDocumentPath + "\\SMS\\Export\\FinalReport") == false)
                    Directory.CreateDirectory(myDocumentPath + "\\SMS\\Export\\FinalReport");
                projectDirectory = myDocumentPath + "\\SMS\\FinalReport\\";
                this.finalReportParameter = parameters;
                mode = ReportMode.FINAL;
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            try
            {
                fileCreated = false;
                bool isCreated = GenerateReport();
                fileCreated = isCreated;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }



        }

        public bool GenerateReport()
        {
            try
            {
                string fileFullPath = "";
                string myDocumentPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string invoiceNumber = "";
                if (mode != ReportMode.FINAL && (mode == ReportMode.SALES || mode == ReportMode.PURCHASE))
                {
                    string fileName = "Invoice_" + DateTime.Now.ToString("yyyymmddHHmmss");
                    fileFullPath = projectDirectory + fileName + ".pdf";
                    ReportDatabaseParametersModel databaseParameters = new ReportDatabaseParametersModel()
                    {
                        InvoiceCategory = mode.ToString(),
                        CreatorId = creatorId,
                        FilePath = fileFullPath,
                        InvoiceDetails = jsonInvoiceString,
                        BillNo = billNumber
                    };
                    databaseParameters.InvoiceDate = mode == ReportMode.SALES ? salesReportParameter.InvoiceDate : purchaseReportParameter.InvoiceDate;
                    databaseParameters.InvoiceDate = GetSqlDateTime(databaseParameters.InvoiceDate);
                    invoiceNumber = InsertInvoiceToDatabase(databaseParameters);

                }
                else if(mode == ReportMode.FINAL)
                {
                    string fileName = "final_report_" + DateTime.Now.ToString("mmssff");
                    fileFullPath = myDocumentPath + "\\SMS\\Export\\FinalReport\\" + fileName + ".pdf";
                }
                else if(mode == ReportMode.LEDGER)
                {
                    string fileName = "Ledger_" + DateTime.Now.ToString("mmssff");
                    fileFullPath = myDocumentPath + "\\SMS\\Export\\Ledger\\" + fileName + ".pdf";
                  
                    ReportDatabaseParametersModel databaseParameters = new ReportDatabaseParametersModel()
                    {
                        InvoiceCategory = mode.ToString(),
                        CreatorId = creatorId,
                        FilePath = fileFullPath,
                        InvoiceDetails = jsonInvoiceString,
                        BillNo = "",
                        InvoiceDate = ""
                       
                    };
                    InsertInvoiceToDatabase(databaseParameters);
                }
                if (mode == ReportMode.PURCHASE) AddReportParameter(invoiceNumber);
                else if (mode == ReportMode.FINAL) AddFinalParameter();
                else if(mode == ReportMode.SALES)AddReportParameterSales(invoiceNumber, salesReportParameter);
                //else if(mode == ReportMode.LEDGER)AddReportParameterLedger();

                ExportToPdf(fileFullPath);

                reportViewer1.RefreshReport();
                bool fileExists = File.Exists(fileFullPath);
                return fileExists;

            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                throw ex;
            }


        }

        //private void AddReportParameterLedger()
        //{

        //    reportViewer1.LocalReport.ReportPath = reportDirectory + "LedgerReport.rdlc";

        //    ReportParameterCollection reportParameters = new ReportParameterCollection();
        //    reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("LedgerDataSet", ledgerReportParameter.ParticularList));
        //    reportParameters.Add(new ReportParameter("companyName", ledgerReportParameter.CompanyName));
        //    reportParameters.Add(new ReportParameter("companyAddress", ledgerReportParameter.CompanyAddress));
        //    reportParameters.Add(new ReportParameter("startDate", ledgerReportParameter.StartDate));
        //    reportParameters.Add(new ReportParameter("endDate", ledgerReportParameter.EndDate));
        //    reportParameters.Add(new ReportParameter("reportStartDate", ledgerReportParameter.ReportStartDate));
        //    reportParameters.Add(new ReportParameter("reportEndDate", ledgerReportParameter.ReportEndDate));
        //    reportParameters.Add(new ReportParameter("debitTotal", ledgerReportParameter.DebitTotal));
        //    reportParameters.Add(new ReportParameter("creditTotal", ledgerReportParameter.CreditTotal));
        //    reportParameters.Add(new ReportParameter("accountName", ledgerReportParameter.AccountName));

        //    reportViewer1.LocalReport.SetParameters(reportParameters);
        //}

        private void AddFinalParameter()
        {

            reportViewer1.LocalReport.ReportPath = reportDirectory + "TimeReport.rdlc";

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("purchaseItem", finalReportParameter.PurchaseItems.ToString()));
            reportParameters.Add(new ReportParameter("purchaseQuantity", finalReportParameter.PurchaseQuantity.ToString()));
            reportParameters.Add(new ReportParameter("purchaseDiscount", finalReportParameter.PurchaseDiscount.ToString()));
            reportParameters.Add(new ReportParameter("purchaseAmount", finalReportParameter.PurchaseTotal.ToString()));
            reportParameters.Add(new ReportParameter("salesItem", finalReportParameter.SalesItems.ToString()));
            reportParameters.Add(new ReportParameter("salesQuantity", finalReportParameter.SalesQuantity.ToString()));
            reportParameters.Add(new ReportParameter("salesDiscount", finalReportParameter.SalesDiscount.ToString()));
            reportParameters.Add(new ReportParameter("salesAmount", finalReportParameter.SalesTotal.ToString()));
            reportParameters.Add(new ReportParameter("reportForDate", finalReportParameter.ReportFor));
            reportParameters.Add(new ReportParameter("stockRemaining", finalReportParameter.StockRemaining.ToString()));
            reportParameters.Add(new ReportParameter("reportDate", finalReportParameter.GeneratedDate));

            reportViewer1.LocalReport.SetParameters(reportParameters);
        }

        
        private void AddReportParameterSales(string invoiceNumber, SalesReportModel reportParameterSales)
        {
            reportViewer1.LocalReport.ReportPath = reportDirectory + "SalesInvoice.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("ProductDataSetSales", reportParameterSales.ParticularsList));

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("invoiceNo", invoiceNumber));
            reportParameters.Add(new ReportParameter("invoiceDate", reportParameterSales.InvoiceDate));
            reportParameters.Add(new ReportParameter("discount", reportParameterSales.Discount.ToString()));
            reportParameters.Add(new ReportParameter("netTotal", reportParameterSales.NetTotal.ToString()));
            reportParameters.Add(new ReportParameter("grandTotal", reportParameterSales.GrandTotal.ToString()));
            reportParameters.Add(new ReportParameter("customerName", reportParameterSales.CustomerName));
            reportParameters.Add(new ReportParameter("customerMobileNumber", reportParameterSales.CustomerNumber.ToString()));
            reportParameters.Add(new ReportParameter("customerAddress", reportParameterSales.CustomerAddress));

            if (!string.IsNullOrEmpty(reportParameterSales.VatNumber))
            {
                reportParameters.Add(new ReportParameter("vatNo", reportParameterSales.VatNumber));
                reportParameters.Add(new ReportParameter("vatLabel", "Vat No:"));
            }


            reportViewer1.LocalReport.SetParameters(reportParameters);
        }

        private string InsertInvoiceToDatabase(ReportDatabaseParametersModel databaseParameters)
        {
            int id = _exportService.
                InsertInvoiceDetails(databaseParameters,partyId);
            string invoiceNumber = "I-" + id.ToString();
            return invoiceNumber;
        }
        private void AddReportParameter(string invoiceNumber)
        {
            reportViewer1.LocalReport.ReportPath = reportDirectory + "InvoiceReport.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("ProductDataSet", purchaseReportParameter.ParticularsList));

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("invoiceNo", invoiceNumber));
            reportParameters.Add(new ReportParameter("invoiceDate", purchaseReportParameter.InvoiceDate));
            reportParameters.Add(new ReportParameter("vatNo", purchaseReportParameter.SupplierVatNo));
            reportParameters.Add(new ReportParameter("discount", purchaseReportParameter.Discount.ToString()));
            reportParameters.Add(new ReportParameter("netTotal", purchaseReportParameter.NetTotal.ToString()));
            reportParameters.Add(new ReportParameter("grandTotal", purchaseReportParameter.GrandTotal.ToString()));

            reportViewer1.LocalReport.SetParameters(reportParameters);
        }
        private void ExportToPdf(string fileFullPath)
        {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string filenameExtension;

                byte[] bytes = reportViewer1.LocalReport.Render(
                    "PDF", null, out mimeType, out encoding, out filenameExtension,
                    out streamids, out warnings);

                using (FileStream fs = new FileStream(fileFullPath, FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }
            
        }
        public string GetSqlDateTime(string date)
        {
            DateTime dateTime = Convert.ToDateTime(date);
            string formattedDate = dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            return formattedDate;
        }
    }
}

public enum ReportMode
{
    SALES,
    PURCHASE,
    FINAL,
    LEDGER
}
