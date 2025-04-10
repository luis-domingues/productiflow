using System.ComponentModel.DataAnnotations;

namespace ProductiFlow.Domain.Models;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required] [EmailAddress] public string Email { get; set; } = string.Empty;

    [Required]
    [StringLength(100, MinimumLength = 4)]
    public string Username { get; set; } = string.Empty;

    [Required]
    [StringLength(100, MinimumLength = 6)]
    public string Password { get; set; } = string.Empty;
}