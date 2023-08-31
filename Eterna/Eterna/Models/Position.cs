using System.ComponentModel.DataAnnotations;

namespace Eterna.Models;
public class Position : BaseEntity
{
    [StringLength(200)]
    public string Name { get; set; }
}