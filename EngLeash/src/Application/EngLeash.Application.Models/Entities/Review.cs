/*�����(Review): 
 
������������� ������(ReviewId)
������������, ���������� ����� (User) 
����, � �������� ��������� ����� (Course) 
����� ������
������
���� ��������� ������*/


public class Review
{
    public int ReviewId { get; set; }
    public User User { get; set; }
    public Course Course { get; set; }
    public string Text { get; set; }
    public int Rating { get; set; }
    public DateTime ReviewDate { get; set; }
}