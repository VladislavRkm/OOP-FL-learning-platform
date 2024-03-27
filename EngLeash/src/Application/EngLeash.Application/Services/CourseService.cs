using EngLeash.Application.Contracts.Interfaces;
using EngLeash.Application.Models.Entities;

namespace EngLeash.Application.Services;

public class CourseService : ICourseService
{
    public Course CreateCourse(string title, string description, int authorId, string languageCode, DateTime createdDate, string difficultyLevel)
    {
        throw new NotImplementedException();
    }

    public bool DeleteCourse(int courseId)
    {
        throw new NotImplementedException();
    }

    public Course GetCourse(int courseId)
    {
        throw new NotImplementedException();
    }

    public bool SetAuthorForCourse(int courseId, int authorId)
    {
        throw new NotImplementedException();
    }

    public Course UpdateCourse(string title, string description, int authorId, string languageCode, string difficultyLevel)
    {
        throw new NotImplementedException();
    }
}
