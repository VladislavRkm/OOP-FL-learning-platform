namespace EngLeash.Infrastructure.Persistence.Models;
public class LessonModel
{
    public int LessonId { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public CourseModel? CourseId { get; set; }
}