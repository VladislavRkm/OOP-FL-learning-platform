using Engleash.src.Application.Engleash.Application.Abstractions;

namespace Engleash.Application.Abstractions.Persistence.Repositories;

public class PersistenceContext : IPersistenceContext
{
    private readonly DatabaseContext _context;

    public PersistenceContext(
        ICertificateRepository certificates,
        ICourseRepository courses,
        ILessonRepository lessons,
        ILessonPassedRepository passedLessons,
        IUserRepository users)
    {
        Certificates = certificates;
        Courses = courses;
        Lessons = lessons;
        PassedLessons = passedLessons;
        Users = users;
    }    
    
    public ICertificateRepository Certificates { get; }
    
    public ICourseRepository Courses { get; }
    
    public ILessonRepository Lessons { get; }
    
    public ILessonPassedRepository PassedLessons { get; }
    
    public IUserRepository Users { get; }
}