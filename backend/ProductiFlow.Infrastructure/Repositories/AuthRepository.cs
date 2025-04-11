using Microsoft.EntityFrameworkCore;
using ProductiFlow.Application.Common.DTOs;
using ProductiFlow.Application.Common.Interfaces;
using ProductiFlow.Domain.Models;
using ProductiFlow.Infrastructure.Data;

namespace ProductiFlow.Infrastructure.Repositories;

public class AuthRepository : IAuthRepository
{
    private readonly AppDbContext _context;

    public AuthRepository(AppDbContext context)
    {
        _context = context;
    }

    public Task<User> Login(LoginRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public async Task<User> Register(RegisterRequestDTO request)
    {
        var existingUser = await _context.Users.FirstOrDefaultAsync(u => 
            u.Email == request.Email || u.Username == request.Username);
        if (existingUser != null) throw new InvalidOperationException("Email ou Username já existente");
        
        var hashedPassword = BCrypt.Net.BCrypt.HashPassword(request.Password);

        var user = new User
        {
            Username = request.Username,
            Email = request.Email,
            Password = hashedPassword
        };
        
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
        return user;
    }
}