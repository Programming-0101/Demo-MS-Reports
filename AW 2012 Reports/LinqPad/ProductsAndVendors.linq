<Query Kind="Expression">
  <Connection>
    <ID>9193e476-04e4-4bf1-a3c1-15f33e7d1b3d</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>AdventureWorks2012</Database>
  </Connection>
</Query>

// Flat data for Products by Vendor
from data in ProductVendors
select new
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
}