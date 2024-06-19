using System.ComponentModel.DataAnnotations;

namespace TestFujitsu.Models;

public class Storage
{
    public int Id { get; set; }

    [Required]
    public string Code { get; set; }

    [Required]
    public string Name { get; set; }
}