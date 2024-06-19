using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestFujitsu.Models;

public class Stuff
{
    public int Id { get; set; }

    [Required]
    public string Code { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public int Stock { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [Required]
    public DateTime ExpDate { get; set; }

    [Required]
    public string Status { get; set; }

    [Required]
    public int StorageId { get; set; }

    [ForeignKey("StorageId")]
    public Storage Storage { get; set; }
}