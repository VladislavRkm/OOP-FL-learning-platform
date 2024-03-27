using EngLeash.Application.Models.Entities;

namespace EngLeash.Application.Contracts.Interfaces;
public interface ICertificateService
{
    Certificate CreateCertificate(int userId, int courseId);
}