/*Курс(Course): 
 
Идентификатор(CourseId)
Название(Title)
Описание(Description)
Идентификатор автора (AuthorId)
Код языка (LanguageCode)
Дата создания курса (CreatedDate)
Уровень сложности(DifficultyLevel)
*/


public class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int AuthorId { get; set; }
    public string LanguageCode { get; set; }
    public DateTime CreatedDate { get; set; }
    public string DifficultyLevel { get; set; }
}