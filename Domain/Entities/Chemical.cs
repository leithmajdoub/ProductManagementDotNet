using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Chemical : Product 
    {
        public string City{ get; set; }
        public string LabName { get; set; }
        public string StreetAdress { get; set; }
        public override void getDetails()
        {
            Console.WriteLine("City: " + City + " LabName: " + LabName);

        }
    }
}
