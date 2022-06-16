using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Provider : Concept
    {
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        public string Password{ get; set; }
        public string ConfirmPassword{ get; set; }
        public string UserName { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
        public override void getDetails()
        {
            Console.WriteLine("ProviderId: " + Id + " Email: " + Email);
        }
    }
}
