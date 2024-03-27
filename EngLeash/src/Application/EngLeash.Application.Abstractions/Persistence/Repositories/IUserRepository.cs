using EngLeash.Application.Models.Entities;

namespace EngLeash.Application.Abstractions.Persistence.Repositories;
public interface IUserRepository
{
    public User CreateUser(User user);

    public User UpdateUser(User user);

    public IEnumerable<User> GetAllUsers();

    public User GetUser(int id);

    public void DeleteUser(int id);
}
