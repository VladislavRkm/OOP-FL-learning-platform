/*�������������(UserId)
���(FirstName)
�������(LastName)
����������� �����(Email)
������(Password)
���� �����������(RegistrationDate)
����(Role) - ��������, �������, �������������
*/


public class User
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime RegistrationDate { get; set; }
    public string Role { get; set; }
}