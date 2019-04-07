using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSIS_2450_Website.Models {
  public class Categories {
    [Key]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string Name { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(250)")]
    public string Description { get; set; }

    [Required]
    public int Priority { get; set; }

    [Required]
    public int UserId { get; set; }
  }
}