using EngLeash.Application.Models.Entities;

namespace EngLeash.Application.Abstractions.Persistence.Repositories;
public interface ICourseRepository
{
    public Course CreateCourse(Course course);

    public Course UpdateCourse(Course course);

    public Course DeleteCourse(Course course);

    public Course GetCourseById(int id);
}
