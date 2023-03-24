using System.ComponentModel.DataAnnotations;

namespace SanaPrakt1.Models
{
    public class Person
    {
        [Required(ErrorMessage="This field is required!")]
        [Display(Name="Input your name")]
        [StringLength(30, ErrorMessage = "The name must be no more than 30 characters long!")]
        [RegularExpression(@"^[A-z А-яії]+$", ErrorMessage = "The name must not consist of characters other than letters!")]
        public string Name { get; set; } = string.Empty;
    }
}
