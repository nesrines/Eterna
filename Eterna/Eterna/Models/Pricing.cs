using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eterna.Models;
public class Pricing : BaseEntity
{
    [StringLength(20)]
    public string Name { get; set; }
    [Column(TypeName = "smallmoney")]
    public int Price { get; set; }
    public bool IsFeatured { get; set; }
}