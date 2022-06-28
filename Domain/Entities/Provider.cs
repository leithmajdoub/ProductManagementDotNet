using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class Provider : Concept
    {
        public DateTime DateCreated { get; set; }
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Key]
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        [Required]
        [MaxLength(8)]
        [DataType(DataType.Password)]
        private string Password;
        [Required]
        [Compare("Password", ErrorMessage = "incorrect Password")]
        [DataType(DataType.Password)]
        [NotMapped]
        public string ConfirmPassword{ get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public override void getDetails()
        {
            Console.WriteLine("ProviderId: " + Id + " Email: " + Email);
        }
        public static void SetIsApproved(Provider p)
        {
            p.IsApproved = string.Compare(p.Password, p.ConfirmPassword) == 0;
        }
        public static void SetIsApproved(string password, string confirmPassword, bool isApproved)
        {
            isApproved = string.Compare(password, confirmPassword) == 0;
        }

        public string password { 
            get { return Password; }
            set { if (value.Length >= 5 && value.Length >= 20) Password = value;
                else Console.WriteLine("Le password doit avoir entre 5 et 20 c");
            } }

        public bool Login(string username, string pass)
        {
            return string.Compare(username, UserName) == 0 && string.Compare(pass, Password) == 0;
        }
        public bool Login(string username, string pass, string email)
        {
            return string.Compare(username, UserName) == 0 && string.Compare(pass, Password) == 0 && string.Compare(email,Email) == 0;
        }


    }
}
