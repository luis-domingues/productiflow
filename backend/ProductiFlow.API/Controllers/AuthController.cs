using Microsoft.AspNetCore.Mvc;
using ProductiFlow.Application.Common.DTOs;
using ProductiFlow.Application.Common.Interfaces;
using ProductiFlow.Domain.Models;

namespace ProductiFlow.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<ActionResult<User>> Register(RegisterRequestDTO request)
    {
        var user = await _authService.RegisterUser(request);
        return Ok(user);
    }
}