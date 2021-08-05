using Lib;
using Lib.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SMS.ChildForm
{
    public partial class ReportForm : Form
    {
        List<string> availableYears;
        bool isReportCreated = false;
        string moduleName = "REPORTFORM";
        IReportService _reportService;
        public ReportForm()
        {
            try
            {
                InitializeComponent();
                _reportService = new ReportRepository();
                //availableYears = _reportService.GetAvailableYears();
                foreach (string year in availableYears)
                {
                    yearComboBox.Items.Add(year);
                }
                yearComboBox.Visible = false;
                yearLabel.Visible = false;
                label3.Visible = false;
                monthSelector.Visible = false;
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }

        }

        private void loadChartBtn_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    string selected = reportComboBox.Text.ToLower();
            //    string time = timeComboBox.Text.ToUpper();
            //    string year = "";
            //    if (time == "MONTH") year = yearComboBox.Text;
            //    if (selected == string.Empty || time == string.Empty)
            //    {                  
            //        Helper.ShowInfo("Please select all fields to load chart");
            //        return;
            //    }
            //    else if(time == "MONTH" && year == string.Empty)
            //    {
            //        Helper.ShowInfo("Please select year to load month data from");
            //        return;
            //    }
            //    chart1.Series.Clear();
            //    chart1.Titles.Clear();
            //    chart2.Series.Clear();
            //    chart2.Titles.Clear();

            //    if (selected == "stock")
            //    {
            //        chart1.Series.Add("Purchased Quantity");
            //        chart1.Series["Purchased Quantity"].Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        chart1.Series["Purchased Quantity"].ChartType = SeriesChartType.Pie;
            //        chart1.Series["Purchased Quantity"].IsValueShownAsLabel = true;
            //        chart1.Series["Purchased Quantity"].LabelForeColor = Color.WhiteSmoke;

            //        chart2.Visible = true;
            //        chart2.Series.Add("Sold Quantity");
            //        chart2.Series["Sold Quantity"].Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        chart2.Series["Sold Quantity"].ChartType = SeriesChartType.Pie;
            //        chart2.Series["Sold Quantity"].IsValueShownAsLabel = true;
            //        chart2.Palette = ChartColorPalette.SeaGreen;
            //        chart2.Series["Sold Quantity"].LabelForeColor = Color.WhiteSmoke;


            //        chart2.Legends.Clear();
            //        chart2.Legends.Add("legend1");
            //        chart2.Legends[0].Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //        string titleNamePurchase = selected.ToUpper() + " CHART FOR PURCHASE";
            //        this.chart1.Titles.Add(titleNamePurchase);

            //        string titleNameSales = selected.ToUpper() + " CHART FOR SALES";
            //        this.chart2.Titles.Add(titleNameSales);
            //        chart2.Titles[0].Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            //    }
            //    else
            //    {
            //        chart2.Visible = false;
            //        chart1.Series.Add("Amount");
            //        chart1.Series["Amount"].ChartType = SeriesChartType.Column;
            //        chart1.Series["Amount"].IsValueShownAsLabel = true;
            //        chart1.Series["Amount"].Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        string titleName = selected.ToUpper() + " CHART";
            //        this.chart1.Titles.Add(titleName);
            //    }

            //    chart1.Legends.Clear();
            //    chart1.Legends.Add("legend1");
            //    chart1.Legends[0].Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //    chart1.Titles[0].Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));



            //    //StyleSeries();
            //    List<ChartModel> chartData = GetChartData(selected, time, year);
            //    if (time == "MONTH")
            //    {
            //        var sortedChartData = chartData
            //       .Select(x => new { Name = x, Sort = DateTime.ParseExact(x.Time, "MMMM", CultureInfo.InvariantCulture) })
            //       .OrderBy(x => x.Sort.Month)
            //       .Select(x => x.Name)
            //       .ToArray();
            //        chartData = sortedChartData.ToList();
            //    }
            //    else
            //    {
            //        var sortedChartData = chartData
            //    .Select(x => new { Name = x, Sort = DateTime.ParseExact(x.Time, "yyyy", CultureInfo.InvariantCulture) })
            //    .OrderBy(x => x.Sort.Month)
            //    .Select(x => x.Name)
            //    .ToArray();
            //        chartData = sortedChartData.ToList();
            //    }


            //    currentChartData = chartData;
            //    if (chartData.Count == 0)
            //    {
            //        if (String.IsNullOrEmpty(year))
            //            Helper.ShowInfo("No data found for " + selected + " for " + time);
            //        else
            //            Helper.ShowInfo("No data found for " + selected + " for Months of " + year);
            //    }
            //    monthSelector.Items.Clear();
            //    foreach (ChartModel data in chartData)
            //    {
            //        AddDataToChart(data, selected);
            //        monthSelector.Items.Add(data.Time);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            //    Helper.ShowInfo(ex.Message);
            //}


        }

        //private void AddDataToChart(ChartModel data, string selected)
        //{
        //    switch (selected)
        //    {
        //        case "purchase":
        //            this.chart1.Series["Amount"].Points.AddXY(data.Time.ToString(), data.Purchase.ToString());

        //            break;
        //        case "sales":
        //            this.chart1.Series["Amount"].Points.AddXY(data.Time.ToString(), data.Sales.ToString());
        //            break;
        //        case "stock":
        //            if (data.PurchasedStock.Count != 0)
        //            {
        //                this.chart1.Series["Purchased Quantity"].Points.AddXY(data.Time.ToString(),
        //                    data.PurchasedStock[0].ToString());
        //            }
        //            else
        //            {
        //                this.chart2.Series["Sold Quantity"].Points.AddXY(data.Time.ToString(),
        //                    data.SoldStock[0].ToString());
        //            }
        //            break;
        //        default:
        //            break;

        //    }
        //}

        //private List<ChartModel> GetChartData(string reportFor, string timeFormat, string year = "")
        //{
        //    List<ChartModel> chartData = new List<ChartModel>();
        //    switch (reportFor)
        //    {
        //        case "purchase":
        //            chartData = operation.action.reportOperation.PurchaseVsTime(timeFormat, year);
        //            break;
        //        case "sales":
        //            chartData = operation.action.reportOperation.SalesVsTime(timeFormat, year);
        //            break;
        //        case "stock":
        //            chartData = operation.action.reportOperation.StockVsTime(timeFormat, year);
        //            break;
        //        default:
        //            break;

        //    }
        //    return chartData;
        //}
        private void exportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(timeComboBox.Text == string.Empty || monthSelector.Text == string.Empty || monthSelector.Text == string.Empty)
                {
                    Helper.ShowInfo("Please select all fields to export");
                    return;
                }
                else if(timeComboBox.Text == "Month" && yearComboBox.Text == string.Empty)
                {
                    Helper.ShowInfo("Please select all fields to export");
                    return;
                }
                using (WaitForm waitForm = new WaitForm(ExportReport))
                {
                    waitForm.ShowDialog(this);
                }
                if (isReportCreated == true)
                {
                    Helper.ShowInfo("Report exported successfully");

                }
                else
                {
                    Helper.ShowInfo("Failed to export report");
                }
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }


        }
        void ExportReport()
        {
            //string timeFormat = "";
            //string year = "";
            //timeComboBox.Invoke((MethodInvoker)(() => { timeFormat = timeComboBox.Text; }));
            //yearComboBox.Invoke((MethodInvoker)(() => { year = yearComboBox.Text; }));

            //string selectedMonth = "";
            //monthSelector.Invoke((MethodInvoker)(() => { selectedMonth = monthSelector.Text; }));

            //FinalReportModel model;
            //if (timeFormat.ToLower() == "month")
            //    model = operation.action.reportOperation.GetFinalReport(timeFormat, year, selectedMonth);
            //else
            //    model = operation.action.reportOperation.GetFinalReport(timeFormat, selectedMonth);
            //ExportForm form = new ExportForm(model);
            //form.Show();
            //isReportCreated = form.fileCreated;

        }
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void timeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (timeComboBox.Text == "Month")
                {
                    yearComboBox.Visible = true;
                    yearLabel.Visible = true;
                    if (reportComboBox.Text != "Stock")
                    {
                        label3.Visible = true;
                        monthSelector.Visible = true;
                    }


                }
                else
                {
                    if (reportComboBox.Text != "Stock")
                    {
                        label3.Visible = true;
                        monthSelector.Visible = true;
                    }
                    label3.Text = "Select year to generate report";
                    yearComboBox.Visible = false;
                    yearLabel.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }

        }

        private void reportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (reportComboBox.Text == "Stock")
                {
                    exportBtn.Visible = false;
                    label3.Visible = false;
                    monthSelector.Visible = false;
                }
                else
                {
                    exportBtn.Visible = true;
                    label3.Visible = true;
                    monthSelector.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }

        }
    }
}
