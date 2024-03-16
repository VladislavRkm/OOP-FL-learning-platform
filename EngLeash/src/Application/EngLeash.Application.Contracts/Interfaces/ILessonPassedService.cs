using EngLeash.Application.Models.Entities;

namespace EngLeash.Application.Models.Interfaces;

public interface ILessonPassedService
{
    LessonPassed PassTheLesson(int lessonId, int userId, DateTime lessonPassedDate);
}