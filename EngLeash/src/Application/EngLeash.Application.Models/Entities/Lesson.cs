/*����(Lesson): 
 
�������������(LessonId)
��������(Title)
�������� �����(Content)
���� � ����� ������ (StartTime) 
������������(DurationInMinutes)
����, � �������� ��������� (Course) */
 
public class Lesson
{
    public int LessonId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime StartTime { get; set; }
    public int DurationInMinutes { get; set; }
    public Course RelatedCourse { get; set; }
}