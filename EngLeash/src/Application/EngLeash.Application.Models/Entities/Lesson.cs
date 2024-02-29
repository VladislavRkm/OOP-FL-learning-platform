/*Урок(Lesson): 
 
Идентификатор(LessonId)
Название(Title)
Материал урока(Content)
Дата и время начала (StartTime) 
Длительность(DurationInMinutes)
Курс, к которому относится (Course) */
 
public class Lesson
{
    public int LessonId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime StartTime { get; set; }
    public int DurationInMinutes { get; set; }
    public Course RelatedCourse { get; set; }
}