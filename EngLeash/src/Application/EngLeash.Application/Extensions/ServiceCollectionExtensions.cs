namespace EngLeash.Application.Extensions;

using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddScoped<ILessonService, LessonService>();
        collection.AddScoped<ICertificateService, CertificateService>();
        collection.AddScoped<ICourseService, CourseService>();
        collection.AddScoped<IUserService, UserService>();
        return collection;
    }
}