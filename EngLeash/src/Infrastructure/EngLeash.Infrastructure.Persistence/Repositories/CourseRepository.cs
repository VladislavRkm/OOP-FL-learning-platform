using EngLeash.Application.Models.Entities;
using EngLeash.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using EngLeash.Infrastructure.Persistence.Models;

namespace EngLeash.Infrastructure.Persistence.Repositories;
public class CourseRepository : BaseRepository<Course, CourseModel>
{
    private readonly DatabaseContext _context;

    public CourseRepository(DatabaseContext context)
    {
        _context = context;
    }

    protected override DbSet<Course> DbSet => _context.Courses;

    public IEnumerable<Course> GetElementsList() => _context.Courses.ToList();

    public Course GetElement(int id)
    {
        return _context.Courses.FirstOrDefault(c => c.CourseId == id)!;
    }

    public void Create(Course item)
    {
        _context.Courses.Add(item);
    }

    public void Update(Course item)
    {
        _context.Courses.Update(item);
    }

    public void Delete(int id)
    {
        var course = _context.Courses.FirstOrDefault(c => c.CourseId == id);
        if (course != null)
        {
            _context.Courses.Remove(course);
        }
    }

    public void Save()
    {
        throw new NotImplementedException();
    }

    public void Dispose() { }
}