public interface ICourseSurvice
{
    Course CreateCourse(string title, string description, int AuthorId, string languageCode, DateTime createdDate, string difficultyLevel);
    Course UpdateCourse(string title, string description, int AuthorId, string languageCode, string difficultyLevel);
    bool DeleteCourse(int courseId);
    Course GetCourse(int courseId);
    bool SetAuthorForCourse(int courseId, int AuthorId);
}