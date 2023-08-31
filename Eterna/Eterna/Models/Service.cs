using System.ComponentModel.DataAnnotations;

namespace Eterna.Models;
public class Service : BaseEntity
{
    [StringLength(200)]
    public string? Icon { get; set; }
    [StringLength(50)]
    public string Name { get; set; }
    [StringLength(200)]
    public string? Description { get; set; }
}