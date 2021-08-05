using System.Collections.Generic;

namespace Lib
{   
    public class InvoiceIndexModel
    {
        public InvoiceIndexModel()
        {
            this.InvoiceDetails = new HashSet<InvoiceDetailsModel>();
        }
        public int InvoiceId { get; set; }
        public string FilePath { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatorId { get; set; }
        public string InvoiceCategory { get; set; }
        public int BillNo { get; set; }
        public virtual ICollection<InvoiceDetailsModel> InvoiceDetails { get; set; }
    }
}
