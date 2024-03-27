using EngLeash.Application.Abstractions.Persistence.Repositories;
using EngLeash.Application.Models.Entities;
using EngLeash.Infrastructure.Persistence.Contexts;
using EngLeash.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EngLeash.Infrastructure.Persistence.Repositories;
public class CourseRepository : BaseRepository<Course, CourseModel>, ICourseRepository
{
    private readonly DatabaseContext _context;

    public CourseRepository(DatabaseContext context) : base(context)
    {
        _context = context;
    }

    public Course CreateCourse(Course course)
    {
        throw new NotImplementedException();
    }

    public Course UpdateCourse(Course course)
    {
        throw new NotImplementedException();
    }

    public Course DeleteCourse(Course course)
    {
        throw new NotImplementedException();
    }

    public Course GetCourseById(int id)
    {
        throw new NotImplementedException();
    }

    protected override DbSet<CourseModel> DbSet => _context.Certificates;

    protected override CourseModel MapFrom(Course entity)
    {
        throw new UnreachableException($"Method {nameof(CourseRepository)}.{nameof(MapFrom)} should be called");
    }

    protected override bool Equal(Course entity, CourseModel model)
    {
        return entity.CourseId.Equals(model.CourseId);
    }

    protected override void UpdateModel(CourseModel model, Course entity)
    {
        model.CourseId = entity.CourseId;
        model.Title = entity.Title;
        model.Description = entity.Description;
        model.AuthorId = entity.AuthorId;
        model.LanguageCode = entity.LanguageCode;
        model.CreatedDate = entity.CreatedDate;
        model.DifficultyLevel = entity.DifficultyLevel;
    }

}
