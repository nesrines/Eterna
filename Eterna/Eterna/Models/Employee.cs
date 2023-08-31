using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class Employee : BaseEntity
    {
        [StringLength(255)]
        public string Image { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)] 
        public string? Surname { get; set; }
        
        [StringLength(255)]
        public string? Info { get; set; }
        [StringLength(255)]
        public string? TwitterUrl { get; set; }
        [StringLength(255)]
        public string? FacebookUrl { get; set; }
        [StringLength(255)]
        public string? IntagramUrl { get; set; }
        [StringLength(255)]
        public string? LinkedInUrl { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }

    }
}