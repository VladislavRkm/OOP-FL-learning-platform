namespace EngLeash.Application.Models.Entities;
public class Certificate
{
    public int CertificateId { get; set; }

    public User? UserId { get; set; }

    public Course? CourseId { get; set; }

    public int PercentOfPassed { get; set; }
}