using EngLeash.Application.Models.Entities;

namespace EngLeash.Application.Abstractions.Persistence.Repositories;
public interface ICertificateRepository
{
    public Certificate CreateCertificate(int certificateId);
}
