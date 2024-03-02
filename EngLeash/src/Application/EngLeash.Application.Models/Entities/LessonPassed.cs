public class LessonPassed
{
	public int LessonPassedId { get; set; }
	public Lesson LessonId { get; set; }
	public User UserId { get; set; }
	public DateTime LessonPassedDate { get; set; }
    public bool LessonIsPassed { get; set; }
}