/*Курс(Course): 
 
Идентификатор(CourseId)
Название(Title)
Описание(Description)
Уровень сложности(DifficultyLevel)
Продолжительность(DurationInWeeks)
Язык курса(Language)
Преподаватель(Teacher)
Список уроков(Lessons)*/


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