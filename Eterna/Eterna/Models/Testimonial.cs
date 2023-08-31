using System.ComponentModel.DataAnnotations;

namespace Eterna.Models;
public class Testimonial : BaseEntity
{
    [StringLength(255)]
    public string? Image { get; set; }
    [StringLength(50)]
    public string Name { get; set; }
    [StringLength(50)]
    public string? Surname { get; set; }
    [StringLength(100)]
    public string Position { get; set; }
    [StringLength(500)]
    public string Comment { get; set; }
}