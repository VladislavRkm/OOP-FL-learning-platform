public interface IUserService
{
    User CreateUser(string FirstName, string LastName, string Email, string Password, DateTime RegistrationDate);
    User EditUser(int UserId, string? FirstName, string? LastName, string? Email, string? Password, DateTime? RegistrationDate);
    bool DeleteUser(int UserId);
    User GetUser(int UserId);