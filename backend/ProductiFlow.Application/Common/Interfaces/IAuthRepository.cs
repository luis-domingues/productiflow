using ProductiFlow.Application.Common.DTOs;
using ProductiFlow.Domain.Models;

namespace ProductiFlow.Application.Common.Interfaces;

public interface IAuthRepository
{
    Task<User> Login(LoginRequestDTO request);
    Task<User> Register(RegisterRequestDTO request);
}