/*
Пользователь (User): 
 
Идентификатор (UserId) 
Имя (FirstName) 
Фамилия (LastName) 
Электронная почта (Email) 
Пароль (Password) 
Дата регистрации (RegistrationDate) 
Роль (Role) - например, студент, преподаватель 
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
Курс (Course): 
 
Идентификатор (CourseId) 
Название (Title) 
Описание (Description) 
Уровень сложности (DifficultyLevel) 
Продолжительность (DurationInWeeks) 
Язык курса (Language) 
Преподаватель (Teacher) 
Список уроков (Lessons)
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
Урок (Lesson): 
 
Идентификатор (LessonId) 
Название (Title) 
Материал урока (Content) 
Дата и время начала (StartTime) 
Длительность (DurationInMinutes) 
Курс, к которому относится (Course)
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
Отзыв (Review): 
 
Идентификатор отзыва (ReviewId) 
Пользователь, написавший отзыв (User) 
Курс, к которому относится отзыв (Course) 
Текст отзыва 
Дата написания отзыва
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
Преподаватель (Instructor): 
 
Идентификатор преподавателя (InstructorId) 
Имя (FirstName) 
Фамилия (LastName) 
Электронная почта (Email) 
Роль (Role) - (преподаватель) 
Курсы, которые ведет (Courses)
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