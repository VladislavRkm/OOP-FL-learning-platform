namespace DefaultNamespace;

public interface ILessonService
{
    Lesson CreateLesson(int courseId, string name, string description, int duration);
    Lesson GetLesson(int lessonId);
    void UpdateLesson(Lesson lesson, string name, string description, int duration);
    void DeleteLesson(int lessonId);
    LessonPassed PassLesson(int lessonId, int userId);
}