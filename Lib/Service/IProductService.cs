using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Service
{
    public interface IProductService
    {
        bool UpdateProduct(ProductDetailsModel product);
        bool UpdateInventory(List<ProductDetailsModel> productList, string updateMode);
        DataTable ConvertToDataTable<T>(IList<T> data);
        DataTable GetProductData();
        bool AddProduct(ProductDetailsModel product);
        bool DeleteProduct(int productId);
        List<ProductDetailsModel> GetProduct();
        bool UpdateProductQuantity(ProductDetailsModel product);
        ProductDetailsModel GetSingleProduct(int productId);
    }
}
