namespace DefaultNamespace;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public User CreateUser(string firstName, string lastName, string email, string password)
    {
        _userRepository.CreateUser(new User
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = password,
            RegistrationDate = DateTime.Now
        });
    }

    public User GetUser(int userId)
    {
        _userRepository.GetUser(userId);
    }

    public void UpdateUser(User user, string firstName, string lastName, string email, string password)
    {
        _userRepository.UpdateUser(user, firstName, lastName, email, password);
    }

    public void DeleteUser(int userId)
    {
        _userRepository.DeleteUser(userId);
    }
}