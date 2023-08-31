﻿using System.ComponentModel.DataAnnotations;

namespace Eterna.Models;
public class BaseEntity
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    [StringLength(100)]
    public string CreatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    [StringLength(100)]
    public string? UpdatedBy { get; set; }
    public DateTime? DeletedAt { get; set; }
    [StringLength(100)]
    public string? DeletedBy { get; set; }
}