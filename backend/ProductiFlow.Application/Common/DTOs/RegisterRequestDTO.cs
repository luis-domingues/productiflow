using System.ComponentModel.DataAnnotations;

namespace ProductiFlow.Application.Common.DTOs;

public class RegisterRequestDTO
{
    [Required]
    [StringLength(100, MinimumLength = 4)]
    public string Username { get; set; } = string.Empty;
    
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [StringLength(100, MinimumLength = 6)]
    public string Password { get; set; } = string.Empty;

    [Required]
    [Compare("Password", ErrorMessage = "As senhas não coincidem.")]
    public string ConfirmPassword { get; set; } = string.Empty;
}