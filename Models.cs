/*
������������ (User): 
 
������������� (UserId) 
��� (FirstName) 
������� (LastName) 
����������� ����� (Email) 
������ (Password) 
���� ����������� (RegistrationDate) 
���� (Role) - ��������, �������, ������������� 
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

/*
���� (Course): 
 
������������� (CourseId) 
�������� (Title) 
�������� (Description) 
������� ��������� (DifficultyLevel) 
����������������� (DurationInWeeks) 
���� ����� (Language) 
������������� (Teacher) 
������ ������ (Lessons)
*/
public class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string LanguageLevel { get; set; }
    public int DurationInWeeks { get; set; }
    public string Language { get; set; }
    public User Teacher { get; set; }
    public List<Lesson> Lessons { get; set; }
}

/*
���� (Lesson): 
 
������������� (LessonId) 
�������� (Title) 
�������� ����� (Content) 
���� � ����� ������ (StartTime) 
������������ (DurationInMinutes) 
����, � �������� ��������� (Course)
*/

public class Lesson
{
    public int LessonId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime StartTime { get; set; }
    public int DurationInMinutes { get; set; }
    public Course RelatedCourse { get; set; }
}

/*
����� (Review): 
 
������������� ������ (ReviewId) 
������������, ���������� ����� (User) 
����, � �������� ��������� ����� (Course) 
����� ������ 
���� ��������� ������
*/

public class Review
{
    public int ReviewId { get; set; }
    public User User { get; set; }
    public Course Course { get; set; }
    public string Text { get; set; }
    public DateTime ReviewDate { get; set; }
}

/*
������������� (Instructor): 
 
������������� ������������� (InstructorId) 
��� (FirstName) 
������� (LastName) 
����������� ����� (Email) 
���� (Role) - (�������������) 
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