namespace DefaultNamespace;

public interface IUserService
{
    User CreateUser(string firstName, string lastName, string email, string password);
    User GetUser(int userId);
    void UpdateUser(User user, string firstName, string lastName, string email, string password);
    void DeleteUser(int userId);
}