using ProductiFlow.Application.Common.DTOs;
using ProductiFlow.Domain.Models;

namespace ProductiFlow.Application.Common.Interfaces;

public interface IAuthService
{
    Task<User> LoginUser(LoginRequestDTO request);
    Task<User> RegisterUser(RegisterRequestDTO request);
}