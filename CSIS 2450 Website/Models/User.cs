using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSIS_2450_Website.Models {
  public class User {
    [Key]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string Name { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(250)")]
    public string Password { get; set; }
  }
}