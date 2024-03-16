namespace EngLeash.Infrastructure.Persistence.Models;
public class UserModel()
{
    public int UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? EmailUser { get; set; }

    public string? PasswordUser { get; set; }

    public DateTime RegistrationDate { get; set; }

}