using System.ComponentModel.DataAnnotations;

namespace Eterna.Models;
public class Detail : BaseEntity
{
    [StringLength(100)]
    public string ServiceName { get; set; }
}