using System.Collections.Generic;
namespace Lib.Models
{
    public class PurchaseReportModel
    {
        public List<ProductDetailsModel> ParticularsList { get; set; }
        public string NetTotal { get; set; }
        public string Discount { get; set; }
        public string GrandTotal { get; set; }
        public string SupplierVatNo { get; set; }
        public string InvoiceDate { get; set; }
    }

    public class SalesReportModel
    {
        public List<ProductDetailsModel> ParticularsList { get; set; }
        public string NetTotal { get; set; }
        public string Discount { get; set; }
        public string GrandTotal { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerAddress { get; set; }
        public string InvoiceDate { get; set; }
        public string VatNumber { get; set; }

    }

   
    public class FinalReportModel
    {
        public string PurchaseItems { get; set; }
        public string PurchaseQuantity { get; set; }
        public string PurchaseDiscount { get; set; }
        public string PurchaseTotal { get; set; }
        public string SalesItems { get; set; }
        public string SalesQuantity { get; set; }
        public string SalesDiscount { get; set; }
        public string SalesTotal { get; set; }
        public string StockRemaining { get; set; }
        public string GeneratedDate { get; set; }
        public string ReportFor { get; set; }
    }
    
}
