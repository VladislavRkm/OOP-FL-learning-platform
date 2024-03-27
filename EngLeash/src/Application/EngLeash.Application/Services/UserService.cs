using EngLeash.Application.Contracts.Interfaces;
using EngLeash.Application.Models.Entities;

namespace EngLeash.Application.Services;

public class UserService : IUserService
{
    public User CreateUser(string firstName, string lastName, string email, string password, DateTime registrationDate)
    {
        throw new NotImplementedException();
    }

    public bool DeleteUser(int userId)
    {
        throw new NotImplementedException();
    }

    public User EditUser(int userId, string? firstName, string? lastName, string? email, string? password, DateTime? registrationDate)
    {
        throw new NotImplementedException();
    }

    public User GetUser(int userId)
    {
        throw new NotImplementedException();
    }
}