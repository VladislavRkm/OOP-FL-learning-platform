namespace DefaultNamespace;

public interface ICourseService
{
    Course CreateCourse(string name, string description, int duration);
    Course GetCourse(int courseId);
    void UpdateCourse(Course course, string name, string description, int duration);
    void DeleteCourse(int courseId);
    void AddUserToCourse(int courseId, int userId);
    void RemoveUserFromCourse(int courseId, int userId);
}