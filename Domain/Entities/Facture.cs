using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Facture
    {
        public int ProductFk { get; set; }

        [ForeignKey("Productid")]
        public virtual Product Product { get; set; }
        [Key, Column(Order = 2)]

        public int ClientFk { get; set; }
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        public DateTime DateAchat { get; set; }
        public float Prix { get; set; }
    }
}
