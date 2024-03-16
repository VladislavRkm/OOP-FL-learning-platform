using EngLeash.Application.Models.Entities;

namespace EngLeash.Application.Models.Interfaces;
public interface ILessonService
{
    Lesson CreateLesson(string title, string content, int courseId);

    Lesson EditLesson(int lessonId, string title, string content, int courseId);

    bool DeleteLesson(int lessonId);

    Lesson GetLesson(int lessonId);
}