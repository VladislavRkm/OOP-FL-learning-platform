/*
������������� �������� ����� (LessonPassedId)
������������� ����� (LessonId)
������������� ������������, ������� �������� ���� (UserId)
����, ����� ������������ �������� ���� (LessonPassedDate)
*/

public class LessonPassed
{
	public int LessonPassedId { get; set; }
	public int LessonId { get; set; }
	public int UserId { get; set; }
	public DateTime LessonPassedDate { get; set; }
}