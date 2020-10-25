using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary
{
    public class ProductDB
    {
        string strConnection;

        public string getConnectionString()
        {
            string strConnection = "server=DESKTOP-LVLR7JR;database=SaleDB;uid=sa;pwd=123456789";
            return strConnection;
        }

        public ProductDB()
        {
            strConnection = getConnectionString();
        }

        public DataTable GetProducts()
        {
            string SQL = "SELECT * FROM Products";
            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable DataProduct = new DataTable();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da.Fill(DataProduct);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                conn.Close();
            }
            return DataProduct;
        }

        public bool AddNewProduct(Product product)
        {
            SqlConnection conn = new SqlConnection(strConnection);
            string SQL = "INSERT Products VALUES(@ProductID, @ProductName, @Quantity, @UnitPrice)";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@ProductID", product.ProductID);
            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
            cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return count > 0;
        }

        public bool UpdateProduct(Product product)
        {
            SqlConnection conn = new SqlConnection(strConnection);
            string SQL = "UPDATE Products SET ProductName=@ProductName, Quantity=@Quantity," +
                " UnitPrice=@UnitPrice WHERE ProductID=@ProductID";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@ProductID", product.ProductID);
            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
            cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return count > 0;
        }

        public bool DeleteProduct(int ProductID)
        {
            SqlConnection conn = new SqlConnection(strConnection);
            string SQL = "DELETE Products WHERE ProductID = @ProductID";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@ProductID", ProductID);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return count > 0;
        }

        public DataTable FindByID(int ProductID)
        {
            SqlConnection conn = new SqlConnection(strConnection);
            string SQL = "SELECT * FROM Products" +
                " WHERE ProductID = @ProductID";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@ProductID", ProductID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable DataProduct = new DataTable();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da.Fill(DataProduct);
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                conn.Close();
            }
            return DataProduct;
        }

    }
}
