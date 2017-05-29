using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW.Framework.ReportModels
{
    public class VendorProductsInfo
    {
        public string ProductName { get; internal set; }
        public string Number { get; internal set; }
        public decimal SellingPrice { get; internal set; }
        public decimal StandardPurchasePrice { get; internal set; }
        public int MinOrder { get; internal set; }
        public int MaxOrder { get; internal set; }
        public string Unit { get; internal set; }
        public int LeadTime { get; internal set; }
        public string Vendor { get; internal set; }
    }
}
