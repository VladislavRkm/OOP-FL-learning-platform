using EngLeash.Application.Contracts.Interfaces;
using EngLeash.Application.Models.Entities;

namespace EngLeash.Application.Services;
internal class LessonService : ILessonService
{
    public Lesson CreateLesson(string title, string content, int courseId)
    {
        throw new NotImplementedException();
    }

    public bool DeleteLesson(int lessonId)
    {
        throw new NotImplementedException();
    }

    public Lesson EditLesson(int lessonId, string title, string content, int courseId)
    {
        throw new NotImplementedException();
    }

    public Lesson GetLesson(int lessonId)
    {
        throw new NotImplementedException();
    }
}
