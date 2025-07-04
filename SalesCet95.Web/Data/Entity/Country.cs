using System.ComponentModel.DataAnnotations;

namespace SalesCet95.Web.Data.Entity
{
    public class Country
    {
        // This class represents a country entity with an ID and a name.
        // business model class
        public int Id { get; set; }


        // Concept Data annotation
        [Display(Name = "Country")]
        // Message this error if the name is empty
        [MaxLength(50, ErrorMessage = "the {0} field must have at most {1} character!!!")]
        // Message this error if the name is empty
        [Required(ErrorMessage = "the {0} field is required!!!")]
        public string Name { get; set; } = string.Empty;

    }
}
