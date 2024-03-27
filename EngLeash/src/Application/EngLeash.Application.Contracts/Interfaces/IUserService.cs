using EngLeash.Application.Models.Entities;

namespace EngLeash.Application.Contracts.Interfaces;

public interface IUserService
{
    User CreateUser(string firstName, string lastName, string email, string password, DateTime registrationDate);

    User EditUser(int userId, string? firstName, string? lastName, string? email, string? password, DateTime? registrationDate);

    bool DeleteUser(int userId);

    User GetUser(int userId);
}