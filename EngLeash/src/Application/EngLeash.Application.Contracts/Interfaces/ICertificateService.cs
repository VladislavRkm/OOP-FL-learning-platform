using EngLeash.Application.Models.Entities;

namespace EngLeash.Application.Models.Interfaces;
public interface ICertificateService
{
    Certificate CreateCertificate(int userId, int courseId);
}