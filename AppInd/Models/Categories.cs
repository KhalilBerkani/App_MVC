using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppInd.Models
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Nom du Categorie")]
        public string Name { get; set; }
        [DisplayName("Ordre du Categorie")]
        public int DisplayOrder { get; set; }
    }
}
