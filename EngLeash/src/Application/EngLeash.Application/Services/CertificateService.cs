using EngLeash.Application.Contracts.Interfaces;
using EngLeash.Application.Models.Entities;
using EngLeash.Infrastructure.Persistence.Repositories;

namespace EngLeash.Application.Services;
internal class CertificateService : ICertificateService
{
    private readonly CertificateRepository _certificateRepository;

    public CertificateService(CertificateRepository certificateRepository)
    {
        _certificateRepository = certificateRepository;
    }

    public Certificate CreateCertificate(User user, Course course) => _certificateRepository.CreateCertificate(new Certificate
        {
            1, user, course, 100,
        });

    public Certificate CreateCertificate(int userId, int courseId)
    {
        throw new NotImplementedException();
    }
}
