/*
Идентификатор сданного урока (LessonPassedId)
Идентификатор урока (LessonId)
Идентификатор пользователя, который выполнил урок (UserId)
Дата, когда пользователь закончил урок (LessonPassedDate)
*/

public class LessonPassed
{
	public int LessonPassedId { get; set; }
	public int LessonId { get; set; }
	public int UserId { get; set; }
	public DateTime LessonPassedDate { get; set; }
}