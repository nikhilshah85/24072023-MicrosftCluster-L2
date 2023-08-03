using System.Numerics;

namespace shoppingAPP_MVC.Models
{
    public class productsDetails
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public int productPrice { get; set; }
        public bool productIsInStock { get; set; }

        static List<productsDetails> pList = new List<productsDetails>()
        {
            new productsDetails(){ productId=101, productName="Pepsi", productDescription="Cold-Drink", productIsInStock=true, productPrice=80},
            new productsDetails(){ productId=102, productName="IPhone", productDescription="Electronics", productIsInStock=true, productPrice=80},
            new productsDetails(){ productId=103, productName="Air-Pods", productDescription="Electronics", productIsInStock=false, productPrice=80},
            new productsDetails(){ productId=104, productName="Fossil Q", productDescription="Electronics", productIsInStock=true, productPrice=80},
            new productsDetails(){ productId=105, productName="Maggie", productDescription="Fast-Food", productIsInStock=false, productPrice=80},
        };

        public List<productsDetails> GetAllProducts()
        {
            return pList;
        }
    }
}
