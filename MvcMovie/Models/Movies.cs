using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models {

    public class Movie {
        //Keep it DRY (Don't Repeat Yourself)
        //Add Validation in the Model Class Attributes to enforce it in the view
        //DataAnnotations have formatting attributes like DataType and Display

        //Properties starts with capital letter unlike Java.
        // DataType specifies the data type of the property.
        // ? after the the data type indicates that the property is nullable.
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    
        //RegularExpression limits what a user can type in the input field.
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }
        
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(170, 95")]
        //Integer, Double, Float and Numbers in general have inbuild [Required]
        public decimal Price { get; set; }
    }
}