using System.ComponentModel.DataAnnotations;

namespace Eterna.Models;
public class Slide : BaseEntity
{
    [StringLength(255)]
    public string BackgroundImage { get; set; }
    [StringLength(1500)]
    public string Content { get; set; }
}