using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacja_Lab1.Models
{
    public class Club
    {
        public int Id { get; set; }
        [Display(Name = "Nazwa Klubu")]
        [Required]

        public string Club_Name { get; set; }
        [Display(Name = "Data Powstania")]
        [Required]

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Kraj pochodzenia")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]


        public string Nationality { get; set; }
        
    }
}
