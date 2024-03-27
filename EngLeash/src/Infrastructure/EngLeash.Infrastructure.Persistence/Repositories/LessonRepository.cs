using EngLeash.Application.Abstractions.Persistence.Repositories;
using EngLeash.Application.Models.Entities;
using EngLeash.Infrastructure.Persistence.Contexts;
using EngLeash.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EngLeash.Infrastructure.Persistence.Repositories;
public class LessonRepository : BaseRepository<Lesson, LessonModel>, ILessonRepository
{
    private readonly DatabaseContext _context;

    public LessonRepository(DatabaseContext context) : base(context)
    {
        _context = context;
    }

    protected override DbSet<LessonModel> DbSet => _context.Lessons;

    protected override LessonModel MapFrom(Lesson entity)
    {
        throw new UnreachableException($"Method {nameof(LessonRepository)}.{nameof(MapFrom)} should be called");
    }

    protected override bool Equal(Lesson entity, LessonModel model)
    {
        return entity.LessonId.Equals(model.LessonId);
    }

    protected override void UpdateModel(LessonModel model, Lesson entity)
    {
        model.LessonId = entity.LessonId;
        model.Title = entity.Title;
        model.Content = entity.Content;
        model.CourseId = entity.CourseId;
    }

    public Lesson CreateLesson(Lesson lesson)
    {
        throw new NotImplementedException();
    }

    public Lesson UpdateLesson(Lesson lesson)
    {
        throw new NotImplementedException();
    }

    public void DeleteLesson(int id)
    {
        throw new NotImplementedException();
    }

    public Lesson GetLesson(Lesson lesson)
    {
        throw new NotImplementedException();
    }
}
