using EngLeash.Application.Models.Entities;

namespace EngLeash.Application.Models.Interfaces;
public interface ICourseService
{
    Course CreateCourse(string title, string description, int authorId, string languageCode, DateTime createdDate, string difficultyLevel);

    Course UpdateCourse(string title, string description, int authorId, string languageCode, string difficultyLevel);

    bool DeleteCourse(int courseId);

    Course GetCourse(int courseId);

    bool SetAuthorForCourse(int courseId, int authorId);
}