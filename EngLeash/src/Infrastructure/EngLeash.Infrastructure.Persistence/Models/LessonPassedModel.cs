namespace EngLeash.Infrastructure.Persistence.Models;
public class LessonPassedModel
{
    public int LessonPassedId { get; set; }

    public LessonModel? LessonId { get; set; }

    public UserModel? UserId { get; set; }

    public DateTime LessonPassedDate { get; set; }

    public bool LessonIsPassed { get; set; }
}