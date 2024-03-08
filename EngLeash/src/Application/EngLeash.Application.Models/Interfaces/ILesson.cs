public interface ILessonSurvice
{
    Lesson CreateLesson(string title, string content, int courseId);
    Lesson EditLesson(int lessonId, string title, string content, int courseId);
    bool DeleteLesson(int lessonId);
    Lesson GetLesson(int lessonId);
}