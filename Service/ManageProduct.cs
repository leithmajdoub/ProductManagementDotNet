using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using System.Linq;

namespace Service
{
    public class ManageProduct
    {
        private List<Product> products;
        public ManageProduct(List<Product> products)
        {
            this.products = products;
        }
        public delegate void FindProduct(string c);
        public delegate void ScanProduct(Category categorie);

        public List<Product> Get5Chemical(double price)
        {
            var result = from product in products where (product is Chemical && product.Price > price) select product;
            return result.Take(5).ToList();
        }
        public List<Product> GetProductPrice(double price)
        {
            var result = from product in products where product.Price > price select product;
            return result.Skip(2).ToList();
        }
        public double GetAveragePrice()
        {
            var result = from product in products select product.Price;
            return result.Average();
        }
        public Product GetMaxPrice()
        {
            var MaxPrice = (from product in products select product.Price).Max();
            var result2 = from product in products where product.Price == MaxPrice select product;
            return result2.FirstOrDefault();
        }
        public int GetCountProduct(string city)
        {
            var result = from product in products where (product is Chemical) && ((Chemical)product).MyAddress.City.Equals(city) select product;
            return result.ToList().Count();
        }
        public List<Product> GetChemicalCity()
        {
            var result = from product in products where (product is Chemical) orderby ((Chemical)product).MyAddress.City select product;
            return result.ToList();
        }
    }
}
