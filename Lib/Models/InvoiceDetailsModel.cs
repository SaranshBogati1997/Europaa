namespace Lib
{
    using System;
    using System.Collections.Generic;
    
    public class InvoiceDetailsModel
    {
        public int InvoiceDetailId { get; set; }
        public int ItemsCount { get; set; }
        public int TotalQuantity { get; set; }
        public long GrandTotal { get; set; }
        public long TotalDiscount { get; set; }
        public int InvoiceId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceDetails { get; set; }
        public int PartyId { get; set; }
    
        public virtual InvoiceIndexModel InvoiceIndexModel{ get; set; }
    }
}
