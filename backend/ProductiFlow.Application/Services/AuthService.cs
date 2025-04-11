using ProductiFlow.Application.Common.DTOs;
using ProductiFlow.Application.Common.Interfaces;
using ProductiFlow.Domain.Models;

namespace ProductiFlow.Application.Services;

public class AuthService : IAuthService
{
    private readonly IAuthRepository _authRepository;

    public AuthService(IAuthRepository authRepository)
    {
        _authRepository = authRepository;
    }

    public Task<User> LoginUser(LoginRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public async Task<User> RegisterUser(RegisterRequestDTO request)
    {
        if (string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Email)) throw new ArgumentException("Username e Email são obrigatórios");

        if (string.IsNullOrEmpty(request.Password) || request.Password.Length < 6)
            throw new ArgumentException("A senha deve ter ao menos 6 caracteres");

        var user = await _authRepository.Register(request);
        return user;
    }
}