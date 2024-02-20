using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppInd.Models
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [DisplayName("Nom du Categorie")]
        public string Name { get; set; }
        [DisplayName("Ordre du Categorie")]
        [Range(1,20,ErrorMessage ="Entrer un nombre entre 1 et 20 ")]
        public int DisplayOrder { get; set; }
    }
}
