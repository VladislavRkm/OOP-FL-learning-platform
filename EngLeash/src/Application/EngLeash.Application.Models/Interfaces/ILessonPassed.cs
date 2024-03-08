public interface ILessonPassedService
{
	LessonPassed PassTheLesson(int LessonId, int UserId, DateTime LessonPassedDate);
}