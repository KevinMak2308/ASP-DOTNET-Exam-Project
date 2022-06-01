using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models {

    public class Movie {

        //Properties starts with capital letter unlike Java.
        // DataType specifies the data type of the property.
        // ? after the the data type indicates that the property is nullable.
        public int Id { get; set; }
        public string? Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string? Genre { get; set; }
        
        [Column(TypeName = "decimal(170, 95")]
        public decimal Price { get; set; }
    }
}