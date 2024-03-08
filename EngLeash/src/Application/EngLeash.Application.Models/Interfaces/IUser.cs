public interface IUser
{
    bool CreateUser(string FirstName, string LastName, string Email, string Password, DateTime RegistrationDate);
    bool EditUser(int UserId);
    bool DeleteUser(int UserId);
    string GetUser(int UserId);