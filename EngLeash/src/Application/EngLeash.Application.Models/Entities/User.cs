/*Идентификатор(UserId)
Имя(FirstName)
Фамилия(LastName)
Электронная почта(Email)
Пароль(Password)
Дата регистрации(RegistrationDate)
*/


public class User
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime RegistrationDate { get; set; }
}