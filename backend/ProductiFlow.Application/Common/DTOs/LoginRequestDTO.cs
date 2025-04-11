using System.ComponentModel.DataAnnotations;

namespace ProductiFlow.Application.Common.DTOs;

public class LoginRequestDTO
{
    [Required]
    [StringLength(100, MinimumLength = 4)]
    public string Username { get; set; } = string.Empty;
    
    [Required]
    [StringLength(100, MinimumLength = 6)]
    public string Password { get; set; } = string.Empty;
}