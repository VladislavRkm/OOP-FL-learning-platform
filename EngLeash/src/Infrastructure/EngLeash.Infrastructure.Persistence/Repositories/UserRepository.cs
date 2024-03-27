using EngLeash.Application.Abstractions.Persistence.Repositories;
using EngLeash.Application.Models.Entities;
using EngLeash.Infrastructure.Persistence.Contexts;
using EngLeash.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EngLeash.Infrastructure.Persistence.Repositories;
public class UserRepository : BaseRepository<User, UserModel>, IUserRepository
{
    private readonly DatabaseContext _context;

    public UserRepository(DatabaseContext context) : base(context)
    {
        _context = context;
    }

    protected override DbSet<UserModel> DbSet => _context.Users;

    protected override UserModel MapFrom(User entity)
    {
        throw new UnreachableException($"Method {nameof(LessonRepository)}.{nameof(MapFrom)} should be called");
    }

    protected override bool Equal(User entity, UserModel model)
    {
        return entity.UserId.Equals(model.UserId);
    }

    protected override void UpdateModel(UserModel model, User entity)
    {
        model.UserId = entity.UserId;
        model.FirstName = entity.FirstName;
        model.LastName = entity.LastName;
        model.EmailUser = entity.EmailUser;
        model.PasswordUser = entity.PasswordUser;
        model.RegistrationDate = entity.RegistrationDate;
    }

    public User CreateUser(User user)
    {
        throw new NotImplementedException();
    }

    public User UpdateUser(User user)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public User GetUser(int id)
    {
        throw new NotImplementedException();
    }

    public void DeleteUser(int id)
    {
        throw new NotImplementedException();
    }
}
