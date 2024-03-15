namespace DefaultNamespace;

public interface ICertificateService
{
    Certificate CreateCertificate(int UserId, int CourseId);
    Certificate GetCertificate(int CertificateId);
}