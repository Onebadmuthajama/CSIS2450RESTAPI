using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSIS_2450_Website.Models {
  public class Tasks {
    [Key]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string Name { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(250)")]
    public string Description { get; set; }

    [Required]
    public int Category { get; set; }

    [Required]
    public int Priority { get; set; }

    [Required]
    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    [Required]
    public int UserId { get; set; }
  }
}