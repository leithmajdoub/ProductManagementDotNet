using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Category : Concept
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public override void getDetails()
        {
            Console.WriteLine("CategoryId: " + CategoryId + " Name: " + Name );
        }
    }
}
