using System.ComponentModel.DataAnnotations;

namespace defensoresCRUD.Models
{
    public class Rol : EntityBase
    {
        [Required]
        public string type{get; set;}

    }
}