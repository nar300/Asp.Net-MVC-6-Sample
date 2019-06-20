using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Newapp.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        
        [DisplayName("Full Name")]
        [Required(ErrorMessage ="Please Enter your Name")]
        public string Name { get; set; }
        [DisplayName("Date Of Birth")]
        [Required(ErrorMessage ="Please enter your Date of Birth")]
        public string Dob { get; set; }
        [Required(ErrorMessage ="Please enter your Ni Number")]

        [DisplayName("Ni Number")]
        public string NiNumber { get; set; }
        [DisplayName("Home Address")]
        [StringLength(500)]
        public string Address { get; set; }
    }
}
