namespace EngLeash.Infrastructure.Persistence.Models;
public class CertificateModel
{
    public int CertificateId { get; set; }

    public UserModel? UserId { get; set; }

    public CourseModel? CourseId { get; set; }

    public int PercentOfPassed { get; set; }
}