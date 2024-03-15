namespace DefaultNamespace;

public class LessonService : ILessonService
{
    private readonly LessonRepository _lessonRepository;
    private readonly LessonPassedRepository _lessonPassedRepository;
    
    public LessonService(LessonRepository lessonRepository, LessonPassedRepository lessonPassedRepository)
    {
        _lessonRepository = lessonRepository;
        _lessonPassedRepository = lessonPassedRepository;
    }
    
    public Lesson CreateLesson(int courseId, string name, string description, int duration)
    {
        _lessonRepository.CreateLesson(new Lesson
        {
            CourseId = courseId,
            Name = name,
            Description = description,
            Duration = duration
        });
    }
    
    public Lesson GetLesson(int lessonId)
    {
        _lessonRepository.GetLesson(lessonId);
    }
    
    public void UpdateLesson(Lesson lesson, string name, string description, int duration)
    {
        _lessonRepository.UpdateLesson(lesson, name, description, duration);
    }
    
    public void DeleteLesson(int lessonId)
    {
        _lessonRepository.DeleteLesson(lessonId);
    }
    
    public LessonPassed PassLesson(int lessonId, int userId)
    {
        _lessonPassedRepository.CreateLessonPassed(new LessonPassed
        {
            LessonId = lessonId,
            UserId = userId
        });
    }
}