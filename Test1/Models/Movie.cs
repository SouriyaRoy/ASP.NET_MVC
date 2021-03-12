using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Test1.Models
{
    public class Movie
    {
       
        public int ID { get; set; }

        [Required(ErrorMessage = "It is required")]
        public string Title{ get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        [DataType(DataType.Currency, ErrorMessage = "Format not correct")]
        public decimal Price { get; set; }
        
    }
}