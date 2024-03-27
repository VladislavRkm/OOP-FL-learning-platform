using EngLeash.Application.Abstractions.Persistence.Repositories;
using EngLeash.Application.Models.Entities;
using EngLeash.Infrastructure.Persistence.Contexts;
using EngLeash.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EngLeash.Infrastructure.Persistence.Repositories;
public class CertificateRepository : BaseRepository<Certificate, CertificateModel>, ICertificateRepository
{
    private readonly DatabaseContext _context;

    public CertificateRepository(DatabaseContext context) : base(context)
    {
        _context = context;
    }

    public Certificate CreateCertificate(int certificateId)
    {
        throw new NotImplementedException();
    }

    protected override DbSet<CertificateModel> DbSet => _context.Certificates;

    protected override CertificateModel MapFrom(Certificate entity)
    {
        throw new UnreachableException($"Method {nameof(CertificateRepository)}.{nameof(MapFrom)} should be called");
    }

    protected override bool Equal(Certificate entity, CertificateModel model)
    {
        return entity.CertificateId.Equals(model.CertificateId);
    }

    protected override void UpdateModel(CertificateModel model, Certificate entity)
    {
        model.CertificateId = entity.CertificateId;
        model.UserId = entity.UserId;
        model.CourseId = entity.CourseId;
        model.PercentOfPassed = entity.PercentOfPassed;
    }

}
