using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABWinform1
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }

    }
    public class ProductData
    {
        private List<Product> ProductList = new List<Product>();

        public List<Product> GetProductList
        {
            get
            {
                return ProductList;
            }
        }

        public void AddNew(Product p)
        {
            Product pro = Find(p.ProductID);
            if (pro == null)
            {
                ProductList.Add(p);
            }
            else
            {
                throw new Exception("Product is already exists.");
            }
        }

        public void Remove(int ProductID)
        {
            Product p = Find(ProductID);
            if (p != null)
            {
                ProductList.Remove(p);
            }
            else throw new Exception("Product is not founds");

        }

        public Product Find(int ProductID)
        {
            Product p = ProductList.SingleOrDefault
                (pro => pro.ProductID == ProductID);
            return p;
        }
    }
}
