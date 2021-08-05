using Lib.Service;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{

    public class ReportRepository :IReportService
    {
        IDataAccess _dataAccess;
        public ReportRepository()
        {
            _dataAccess = new DataAccess();
        }
        public Dictionary<string, string> GetPurchaseData()
        {
            try
            {
                string query  = "select tmid.InvoiceDetails AS Details, InvoiceDate as Date" +
                       " FROM tbl_mn_InvoiceDetails tmid INNER JOIN tbl_mn_InvoiceIndex tmii " +
                       "ON tmid.InvoiceId = tmii.InvoiceId " +
                       " WHERE tmii.InvoiceCategory='PURCHASE'";
                var details = (IDictionary<string, string>)_dataAccess.Query<object>(query);
                return (Dictionary<string, string>)details;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<string, string> GetSalesData()
        {
            try
            {
                string query = "select tmid.InvoiceDetails AS Details, InvoiceDate as Date" +
                       " FROM tbl_mn_InvoiceDetails tmid INNER JOIN tbl_mn_InvoiceIndex tmii " +
                       "ON tmid.InvoiceId = tmii.InvoiceId " +
                       " WHERE tmii.InvoiceCategory='SALES'";
                var details = (IDictionary<string, string>)_dataAccess.Query<object>(query);
                return (Dictionary<string, string>)details;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //}
        //public List<ChartModel> PurchaseVsTime(string timeFormat, string year)
        //{
        //    try
        //    {
        //        using(context = new SMSEntities())
        //        {

        //        }
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            if (year == string.Empty)
        //                cmd.CommandText = "select DATENAME(" + timeFormat + ", InvoiceDate) as Date ,SUM(GrandTotal) as Amount from tbl_mn_InvoiceDetails d " +
        //                " inner join tbl_mn_InvoiceIndex i on d.InvoiceId = i.InvoiceId" +
        //                " where i.InvoiceCategory = 'PURCHASE' and InvoiceDate is not null" +
        //                " group by DATENAME(" + timeFormat + ", InvoiceDate)";
        //            else
        //                cmd.CommandText = "select " +
        //                "DATENAME(" + timeFormat + ", InvoiceDate) as Date, sum(GrandTotal) as Amount " +
        //                "from tbl_mn_InvoiceDetails d inner " +
        //                "join tbl_mn_InvoiceIndex i " +
        //                "on d.InvoiceId = i.InvoiceId " +
        //                "where i.InvoiceCategory = 'PURCHASE' and year(InvoiceDate) = " + year + " " +
        //                "group by DATENAME(" + timeFormat + ", InvoiceDate)";
        //            cmd.Connection = conn;
        //            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
        //            using (SqlDataReader rdr = cmd.ExecuteReader())
        //            {
        //                List<ChartModel> chartData = new List<ChartModel>();
        //                while (rdr.Read())
        //                {
        //                    chartData.Add(new ChartModel()
        //                    {
        //                        Time = rdr["Date"].ToString(),
        //                        Purchase = Convert.ToDouble(rdr["Amount"])
        //                    });
        //                }
        //                return chartData;
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}
        //public List<ChartModel> SalesVsTime(string timeFormat, string year)
        //{
        //    using (SqlCommand cmd = new SqlCommand())
        //    {
        //        if (year == string.Empty)
        //            cmd.CommandText = "select DATENAME(" + timeFormat + ", InvoiceDate) as Date ,SUM(GrandTotal) as Amount from tbl_mn_InvoiceDetails d " +
        //            " inner join tbl_mn_InvoiceIndex i on d.InvoiceId = i.InvoiceId" +
        //            " where i.InvoiceCategory = 'SALES' and InvoiceDate is not null" +
        //            " group by DATENAME(" + timeFormat + ", InvoiceDate)";
        //        else
        //            cmd.CommandText = "select " +
        //            "DATENAME(" + timeFormat + ", InvoiceDate) as Date, sum(GrandTotal) as Amount " +
        //            "from tbl_mn_InvoiceDetails d inner " +
        //            "join tbl_mn_InvoiceIndex i " +
        //            "on d.InvoiceId = i.InvoiceId " +
        //            "where i.InvoiceCategory = 'SALES' and year(InvoiceDate) = " + year + " " +
        //            "group by DATENAME(" + timeFormat + ", InvoiceDate)";

        //        cmd.Connection = conn;
        //        if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
        //        using (SqlDataReader rdr = cmd.ExecuteReader())
        //        {
        //            List<ChartModel> chartData = new List<ChartModel>();
        //            while (rdr.Read())
        //            {
        //                chartData.Add(new ChartModel()
        //                {
        //                    Time = rdr["Date"].ToString(),
        //                    Sales = Convert.ToDouble(rdr["Amount"])
        //                });
        //            }
        //            return chartData;
        //        }

        //    }
        //}
        //public List<ChartModel> StockVsTime(string timeFormat, string year)
        //{
        //    using (SqlCommand cmd = new SqlCommand())
        //    {
        //        if (year == string.Empty)
        //            cmd.CommandText = "select DATENAME(" + timeFormat + ", InvoiceDate) as Date , sum(TotalQuantity) as TotalQuantity, i.InvoiceCategory from tbl_mn_InvoiceDetails d " +
        //            " inner join tbl_mn_InvoiceIndex i on d.InvoiceId = i.InvoiceId" +
        //            " group by DATENAME(" + timeFormat + ", InvoiceDate), i.InvoiceCategory";
        //        else
        //            cmd.CommandText = "select " +
        //            "DATENAME(" + timeFormat + ", InvoiceDate) as Date, sum(TotalQuantity) as TotalQuantity, i.InvoiceCategory " +
        //            "from tbl_mn_InvoiceDetails d inner " +
        //            "join tbl_mn_InvoiceIndex i " +
        //            "on d.InvoiceId = i.InvoiceId " +
        //            "where year(InvoiceDate) = " + year + " " +
        //            "group by DATENAME(" + timeFormat + ", InvoiceDate), i.InvoiceCategory";

        //        cmd.Connection = conn;
        //        if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
        //        using (SqlDataReader rdr = cmd.ExecuteReader())
        //        {
        //            List<ChartModel> chartData = new List<ChartModel>();
        //            while (rdr.Read())
        //            {
        //                ChartModel model = new ChartModel();
        //                model.Time = rdr["Date"].ToString();
        //                model.PurchasedStock = new List<double>();
        //                model.SoldStock = new List<double>();
        //                if (rdr["InvoiceCategory"].ToString() == "PURCHASE")
        //                {
        //                    double quantity = Convert.ToDouble(rdr["TotalQuantity"]);
        //                    model.PurchasedStock.Add(quantity);
        //                }
        //                else if (rdr["InvoiceCategory"].ToString() == "SALES")
        //                {
        //                    double quantity = Convert.ToDouble(rdr["TotalQuantity"]);
        //                    model.SoldStock.Add(quantity);
        //                }
        //                else
        //                {
        //                    throw new Exception("INVALID COLUMN");
        //                }
        //                chartData.Add(model);
        //            }
        //            return chartData;
        //        }

        //    }
        //}
        //public List<string> GetAvailableYears()
        //{
        //    using (SqlCommand cmd = new SqlCommand())
        //    {
        //        cmd.Connection = conn;
        //        if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
        //        cmd.CommandText = "select distinct YEAR(InvoiceDate) as Years from tbl_mn_InvoiceDetails";
        //        using (SqlDataReader rdr = cmd.ExecuteReader())
        //        {
        //            List<string> availableYear = new List<string>();
        //            while (rdr.Read())
        //            {
        //                availableYear.Add(rdr["Years"].ToString());
        //            }
        //            return availableYear;
        //        }

        //    }
        //}
        //public FinalReportModel GetFinalReport(string timeFormat, string selectedYear, string month = "")
        //{
        //    FinalReportModel model = new FinalReportModel();
        //    using (SqlCommand cmd = new SqlCommand())
        //    {
        //        cmd.Connection = conn;
        //        if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
        //        string additionalWhereClause = "";
        //        if (month != string.Empty) additionalWhereClause = " and DATENAME(MONTH, InvoiceDate) = '" + month + "'";
        //        cmd.CommandText = "select " +
        //            "DATENAME(" + timeFormat + ", InvoiceDate) as Date, sum(TotalQuantity) as TotalQuantity, sum(ItemsCount) as TotalItems, " +
        //            "sum(TotalDiscount) as TotalDiscount,SUM(GrandTotal) as TotalAmount,i.InvoiceCategory " +
        //            "from tbl_mn_InvoiceDetails d inner join tbl_mn_InvoiceIndex i " +
        //            "on d.InvoiceId = i.InvoiceId " +
        //            "where year(InvoiceDate) = " + selectedYear + " " + additionalWhereClause +
        //            " group by DATENAME(" + timeFormat + ", InvoiceDate), i.InvoiceCategory";
        //        using (SqlDataReader rdr = cmd.ExecuteReader())
        //        {

        //            while (rdr.Read())
        //            {
        //                if (rdr["InvoiceCategory"].ToString() == "PURCHASE")
        //                {
        //                    model.PurchaseItems = rdr["TotalItems"].ToString();
        //                    model.PurchaseQuantity = rdr["TotalQuantity"].ToString();
        //                    model.PurchaseDiscount = rdr["TotalDiscount"].ToString();
        //                    model.PurchaseTotal = rdr["TotalAmount"].ToString();
        //                }
        //                else
        //                {
        //                    model.SalesItems = rdr["TotalItems"].ToString();
        //                    model.SalesQuantity = rdr["TotalQuantity"].ToString();
        //                    model.SalesDiscount = rdr["TotalDiscount"].ToString();
        //                    model.SalesTotal = rdr["TotalAmount"].ToString();
        //                }

        //            }
        //            model.GeneratedDate = DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss");
        //            model.StockRemaining = (Convert.ToDouble(model.PurchaseQuantity) - Convert.ToDouble(model.SalesQuantity)).ToString();
        //            if (month != string.Empty) model.ReportFor = month.ToUpper() + "," + selectedYear;
        //            else model.ReportFor = selectedYear;
        //        }
        //        return model;
        //    }
        //}
    }
}
