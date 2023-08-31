using System.ComponentModel.DataAnnotations;

namespace Eterna.Models;
public class Setting
{
    public int Id { get; set; }
    [StringLength(50)]
    public string Key { get; set; }
    [StringLength(500)]
    public string Value { get; set; }
}