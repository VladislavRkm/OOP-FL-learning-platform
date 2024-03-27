using EngLeash.Application.Abstractions.Persistence.Repositories;
using EngLeash.Application.Models.Entities;
using EngLeash.Infrastructure.Persistence.Contexts;
using EngLeash.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EngLeash.Infrastructure.Persistence.Repositories;
public class LessonPassedRepository : BaseRepository<LessonPassed, LessonPassedModel>, ILessonPassedRepository
{
    private readonly DatabaseContext _context;

    public LessonPassedRepository(DatabaseContext context) : base(context)
    {
        _context = context;
    }

    protected override DbSet<LessonPassedModel> DbSet => _context.LessonsPassed;

    protected override LessonPassedModel MapFrom(LessonPassed entity)
    {
        throw new UnreachableException($"Method {nameof(LessonPassedRepository)}.{nameof(MapFrom)} should be called");
    }

    protected override bool Equal(LessonPassed entity, LessonPassedModel model)
    {
        return entity.LessonPassedId.Equals(model.LessonPassedId);
    }

    protected override void UpdateModel(LessonPassedModel model, LessonPassed entity)
    {
        model.LessonPassedId = entity.LessonPassedId;
        model.LessonId = entity.LessonId;
        model.UserId = entity.UserId;
        model.LessonPassedDate = entity.LessonPassedDate;
        model.LessonIsPassed = entity.LessonIsPassed;
    }

    public LessonPassed CreateLessonPassed(LessonPassed lessonPassed)
    {
        throw new NotImplementedException();
    }
}
