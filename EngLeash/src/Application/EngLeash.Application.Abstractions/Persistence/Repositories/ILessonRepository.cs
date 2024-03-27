using EngLeash.Application.Models.Entities;

namespace EngLeash.Application.Abstractions.Persistence.Repositories;
public interface ILessonRepository
{
    public Lesson CreateLesson(Lesson lesson);

    public Lesson UpdateLesson(Lesson lesson);

    public void DeleteLesson(int id);

    public Lesson GetLesson(Lesson lesson);
}
