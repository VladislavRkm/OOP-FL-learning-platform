namespace DefaultNamespace;

public class CourseService : ICourseService
{
    private readonly ICourseRepository _courseRepository;
    
    public CourseService(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }
    public Course CreateCourse(string name, string description, int duration)
    {
        _courseRepository.CreateCourse(new Course
        {
            Name = name,
            Description = description,
            Duration = duration
        });
    }

    public Course GetCourse(int courseId)
    {
        _courseRepository.GetCourse(courseId);
    }

    public void UpdateCourse(Course course, string name, string description, int duration)
    {
        _courseRepository.UpdateCourse(course, name, description, duration);
    }

    public void DeleteCourse(int courseId)
    {
        _courseRepository.DeleteCourse(courseId);
    }

    public void AddUserToCourse(int courseId, int userId)
    {
        _courseRepository.AddUserToCourse(courseId, userId);
    }

    public void RemoveUserFromCourse(int courseId, int userId)
    {
        _courseRepository.RemoveUserFromCourse(courseId, userId);
    }
}