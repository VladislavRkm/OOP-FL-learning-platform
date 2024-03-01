/*Урок(Lesson): 
 
Идентификатор(LessonId)
Название(Title)
Материал урока(Content)
Идентификатор Курса, к которому относится урок (CourseId)
 */
 
public class Lesson
{
    public int LessonId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int CourseId { get; set; }
}