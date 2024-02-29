/*
������������� �������������(InstructorId)
���(FirstName)
�������(LastName)
����������� �����(Email)
����(Role) - ��������, �������, �������������
�����, ������� ����� (Courses) 
*/

public class Instructor
{
    public int InstructorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public List<Course> Courses { get; set; }
}