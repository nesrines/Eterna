using System.ComponentModel.DataAnnotations;

namespace Eterna.Models;
public class Client : BaseEntity
{
    [StringLength(255)]
    public string? Image { get; set; }
    [StringLength(100)]
    public string? Name { get; set; }
}