/*Отзыв(Review): 
 
Идентификатор отзыва(ReviewId)
Пользователь, написавший отзыв (User) 
Курс, к которому относится отзыв (Course) 
Текст отзыва
Оценка
Дата написания отзыва*/


public class Review
{
    public int ReviewId { get; set; }
    public User User { get; set; }
    public Course Course { get; set; }
    public string Text { get; set; }
    public int Rating { get; set; }
    public DateTime ReviewDate { get; set; }
}