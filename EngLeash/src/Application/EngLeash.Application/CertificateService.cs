namespace DefaultNamespace;

public class CertificateService
{
    private readonly CertificateRepository _certificateRepository;
    
    public CertificateService(CertificateRepository certificateRepository)
    {
        _certificateRepository = certificateRepository;
    }
    
    public Certificate CreateCertificate(int UserId, int CourseId)
    {
        _certificateRepository.CreateCertificate(new Certificate
        {
            UserId = UserId,
            CourseId = CourseId
        });
    }
    
    public Certificate GetCertificate(int CertificateId)
    {
        _certificateRepository.GetCertificate(CertificateId);
    }
}