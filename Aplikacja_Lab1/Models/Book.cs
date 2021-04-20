using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacja_Lab1.Models
{
    public class Book
    {
        
        public int Id { get; set; }
        [Display(Name = "Tytuł")]
        [Required]

        public string Title { get; set; }
        [Display(Name = "Data wydania")]
        [Required]

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Gatunek")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]


        public string Genre { get; set; }
        [Display(Name = "Cena")]
        [Required]

        public decimal Price { get; set; }
    }

}
