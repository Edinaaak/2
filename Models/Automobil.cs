using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Net.Mime.MediaTypeNames.Image;

namespace RentaCar.Models
{
    public class Automobili
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NameofImage { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string price { get; set; }
        public string day1 { get; set; }
        public string day2 { get; set; }
        public string day3 { get; set; }
        public string day4 { get; set; }
        public int passengers { get; set; }
        public int doors { get; set; }
        public string engine { get; set; }
        public string gearbox { get; set; }
        public string gasoline { get; set; }  
       
    }
}
