using EngLeash.Application.Models.Entities;

namespace EngLeash.Application.Abstractions.Persistence.Repositories;
public interface ILessonPassedRepository
{
    public LessonPassed CreateLessonPassed(LessonPassed lessonPassed);
}
