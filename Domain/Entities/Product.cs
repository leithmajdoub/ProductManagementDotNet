using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class Product : Concept
    {
        [Display(Name = "Production date")] //affichage
        [DataType(DataType.Date)]
        public DateTime DateProd { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Required")]
        [StringLength(25, ErrorMessage = "Max Length is 25")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public double Price{ get; set; }
        public int ProductId { get; set; }
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public virtual ICollection<Provider> Providers { get; set; }
        public virtual ICollection<Facture> Factures { get; set; }

        public override void getDetails()
        {
            Console.WriteLine("ProductId: " + ProductId + " Name: " + Name + " Price: " + Price + " Quantity: " + Quantity);
        
        }
        public virtual void GetMyType()
        {
            Console.WriteLine("Unknown");
        }

    }
}
