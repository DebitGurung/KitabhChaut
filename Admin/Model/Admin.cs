using System.ComponentModel.DataAnnotations;

public class Admin
{
    public int AdminId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [MaxLength(50)]
    public string Role { get; set; } = "Administrator"; // e.g., SuperAdmin, Support

    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}