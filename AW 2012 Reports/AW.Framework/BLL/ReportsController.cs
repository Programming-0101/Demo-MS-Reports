using AW.Framework.ReportModels;
using DAL.Framework.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace AW.Framework.BLL
{
    [DataObject]
    public class ReportsController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<VendorProductsInfo> ListVendorProducts()
        {
            using (var context = new AWContext())
            {
                var result = from data in context.ProductVendors
                             select new VendorProductsInfo
                             {
                                 ProductName = data.Product.Name,
                                 Number = data.Product.ProductNumber,
                                 SellingPrice = data.Product.ListPrice,
                                 StandardPurchasePrice = data.StandardPrice,
                                 MinOrder = data.MinOrderQty,
                                 MaxOrder = data.MaxOrderQty,
                                 Unit = data.UnitMeasure.Name,
                                 LeadTime = data.AverageLeadTime,
                                 Vendor = data.Vendor.Name
                             };
                return result.ToList();
            }
        }
    }
}
