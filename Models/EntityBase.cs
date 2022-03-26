using System;
using System.ComponentModel.DataAnnotations;

namespace defensoresCRUD.Models
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name{ get; set; }
        public DateTime LastModified { get; set; }
        public bool SoftDelete { get; set; }     
    }
}