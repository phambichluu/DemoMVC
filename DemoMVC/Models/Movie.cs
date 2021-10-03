using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace DemoMVC.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage ="Title is required.")]
        [MaxLength(15)]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Rating { get; set; }
        [EmailAddress]
        public string Email { get; set; }

    }
}
