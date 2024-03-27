using EngLeash.Application.Abstractions.Persistence.Repositories;
using EngLeash.Infrastructure.Persistence.Migrations;
using EngLeash.Infrastructure.Persistence.Plugins;
using EngLeash.Infrastructure.Persistence.Repositories;
using Itmo.Dev.Platform.Postgres.Extensions;
using Itmo.Dev.Platform.Postgres.Plugins;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EngLeash.Infrastructure.Persistence.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructurePersistence(this IServiceCollection collection, IConfiguration configuration)
    {
        collection.AddPlatformPostgres(builder => builder.BindConfiguration("Infrastructure:Persistence:Postgres"));
        collection.AddSingleton<IDataSourcePlugin, MappingPlugin>();

        collection.AddPlatformMigrations(typeof(IAssemblyMarker).Assembly);
        collection.AddHostedService<MigrationRunnerService>();

        // TODO: add repositories
        collection.AddScoped<ICertificateRepository, CertificateRepository>();
        collection.AddScoped<ICourseRepository, CourseRepository>();
        collection.AddScoped<ILessonPassedRepository, LessonPassedRepository>();
        collection.AddScoped<ILessonRepository, LessonRepository>();
        collection.AddScoped<IUserRepository, UserRepository>();

        return collection;
    }
}