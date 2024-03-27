using EngLeash.Application.Contracts.Interfaces;
using EngLeash.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EngLeash.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddScoped<ILessonService, LessonService>();
        collection.AddScoped<ICertificateService, CertificateService>();
        collection.AddScoped<ICourseService, CourseService>();
        collection.AddScoped<IUserService, UserService>();
        collection.AddScoped<ILessonPassedService, LessonPassedService>();
        return collection;
    }
}