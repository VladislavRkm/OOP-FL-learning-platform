public class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public User AuthorId { get; set; }
    public string LanguageCode { get; set; }
    public DateTime CreatedDate { get; set; }
    public string DifficultyLevel { get; set; }
}