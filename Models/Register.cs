
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RentaCar.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName{ get;set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Eadresa { get; set; }
        public string Password { get; set; }
        public int Active { get; set; }


    }
}
