using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Product : Concept
    {
        public DateTime DateProd { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double Price{ get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Category Category { get; set; }
        public virtual IEnumerable<Provider> Providers { get; set; }

        public override void getDetails()
        {
            Console.WriteLine("ProductId: " + ProductId + " Name: " + Name + " Price: " + Price + " Quantity: " + Quantity);
        
        }

    }
}
