using EngLeash.Application.Models.Entities;

namespace EngLeash.Application.Contracts.Interfaces;

public interface ILessonPassedService
{
    LessonPassed PassTheLesson(int lessonId, int userId, DateTime lessonPassedDate);
}