using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Biological : Product
    {
        public string Herbs{ get; set; }
        public override void getDetails()
        {
            Console.WriteLine("Herbs: " + Herbs);

        }
    }
}
