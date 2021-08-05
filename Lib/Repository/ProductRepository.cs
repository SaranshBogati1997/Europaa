using Lib.Service;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace Lib
{
    public class ProductRepository : IProductService
    {
        IDataAccess _dataAccess;
        public ProductRepository()
        {
            _dataAccess = new DataAccess();
        }
        public bool UpdateProduct(ProductDetailsModel product)
        {
            try
            {
                string query = "Update tbl_mn_ProductDetailsDetails set ProductName = @Productname" +
                        " ,Unit =@Unit, Price = @Price where ProductId = @ProductId";
                var obj = _dataAccess.Query<object>(query, product);
                return obj != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateInventory(List<ProductDetailsModel> productList, string updateMode = null)
        {
            try
            {
                DataTable dt = ConvertToDataTable(productList);
                using (var conn = (SqliteConnection)_dataAccess.GetNewConnection())
                {
                    string tempTableName = "##temp_" + Guid.NewGuid().ToString().Replace('-', '_');
                    //Creating temp table on database
                    string tempTableCreateQuery =
                        "CREATE TABLE " + tempTableName + " (" +
                        "[ProductId][int] IDENTITY(1, 1) NOT NULL," +
                        "[ProductName] [nvarchar](100) NOT NULL," +
                        "[Unit] [nvarchar](50) NOT NULL, " +
                        "[CostPrice] [bigint] NULL," +
                        "[ParentGroup] [nvarchar](200) NULL," +
                        "[Quantity] [int] NULL," +
                        "[Total] [bigint] NULL," +
                        "[Description] [nvarchar](200) NULL," +
                        "[SalesPrice] [bigint] NULL," +
                        "[IsTaxable] [bit] NULL," +
                        "[VatPercent] [int] NULL);";

                    var tempCmd = new SqliteCommand(tempTableName, conn);
                    tempCmd.ExecuteNonQuery();

                    //since sqlite does not support sqlbulkcopy using transaction here
                    var transaction = conn.BeginTransaction();
                    try
                    {
                        var command = conn.CreateCommand();
                        foreach (var product in productList)
                        {
                            if (updateMode == "SALES")
                            {
                                command.CommandText = "UPDATE tbl_mn_ProductDetailsDetails SET Quantity = Quantity - @Quantity WHERE ProductId = @ProductId";
                                command.Parameters.AddWithValue("@Quantity", product.Quantity);
                                command.ExecuteNonQuery();
                            }
                            else if (updateMode == "PURCHASE")
                            {
                                command.CommandText = "UPDATE tbl_mn_ProductDetailsDetails SET Quantity = @Quantity WHERE ProductId = @ProductId";
                                command.Parameters.AddWithValue("@Quantity", product.Quantity);
                                command.ExecuteNonQuery();
                            }
                            else if (updateMode == null)
                            {
                                command.CommandText = "INSERT INTO tbl_mn_ProductDetails " +
                                                 "(ProductName, Unit, Price, ParentGroup, Quantity, Total) VALUES " +
                                                 "(@ProductName,@Unit,@Price,@ParentGroup,@Quantity,@Total)";
                                command.Parameters.AddWithValue("@ProductName", product.ProductName);
                                command.Parameters.AddWithValue("@Unit", product.Unit);
                                command.Parameters.AddWithValue("@Price", product.Price);
                                command.Parameters.AddWithValue("@ParentGroup", product.ParentGroup);
                                command.Parameters.AddWithValue("@Quantity", product.Quantity);
                                command.Parameters.AddWithValue("@Total", product.Total);
                                command.ExecuteNonQuery();
                            }
                            
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        throw e;
                    }


                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            try
            {
                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
                DataTable table = new DataTable();
                foreach (PropertyDescriptor prop in properties)
                {

                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }

                foreach (T item in data)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                    {

                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    }

                    table.Rows.Add(row);
                }
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable GetProductData()
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Unit", typeof(string));
                table.Columns.Add("Price", typeof(double));
                table.Columns.Add("Quantity", typeof(double));


                List<ProductDetailsModel> productList = GetProduct();
                foreach (ProductDetailsModel product in productList)
                {

                    table.Rows.Add(product.ProductId, product.ProductName, product.Unit, product.Price, product.Quantity);
                };
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool AddProduct(ProductDetailsModel product)
        {
            try
            {
                string query = "INSERT INTO tbl_mn_ProductDetails " +
                    "(ProductName, Unit, Price, ParentGroup, Quantity, Total) VALUES " +
                    "(@ProductName,@Unit,@Price,@ParentGroup,@Quantity,@Total)";
                return _dataAccess.Query<object>(query, product) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteProduct(int productId)
        {
            try
            {
                string query = "DELETE FROM tbl_mn_ProductDetails WHERE ProductId = @ProductId";
                return _dataAccess.Query<object>(query, new { ProductId = productId }) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<ProductDetailsModel> GetProduct()
        {

            try
            {
                string query = "SELECT *  FROM tbl_mn_ProductDetails ";
                return _dataAccess.Query<ProductDetailsModel>(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public bool UpdateProductQuantity(ProductDetailsModel product)
        {
            try
            {
                string query = "update tbl_mn_ProductDetailsDetails set Quantity = @Quantity where ProductId = @ProductId";
                return _dataAccess.Query<object>(query, product) != null;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public ProductDetailsModel GetSingleProduct(int productId)
        {
            try
            {
                string query = "SELECT *  FROM tbl_mn_ProductDetails WHERE ProductId = @productId";
                return _dataAccess.Query<ProductDetailsModel>(query, productId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
