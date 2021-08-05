
using System.Collections.Generic;

namespace Lib.Models
{

    public class InvoiceJsonModel
    {
        public List<ProductDetailsModel> Particulars { get; set; }
        public string NetTotal { get; set; }
        public string Discount { get; set; }
        public string Vat { get; set; }
        public string GrandTotal { get; set; }
        public string PaidAmount { get; set; }
        public string DueBalance { get; set; }
        public SupplierModel Supplier { get; set; }
        public CustomerModel Customer { get; set; }
        public string InvoiceDate { get; set; }
        public bool IsCredit { get; set; }
    }

}
