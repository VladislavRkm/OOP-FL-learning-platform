﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Engleash.Application.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EngLeash.Infrastructure.Persistence.Contexts;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    protected DatabaseContext(DbContextOptions options) : base(options) { }

    public DbSet<User> Users { get; protected init; } = null!;

    public DbSet<Lesson> Lessons { get; protected init; } = null!;

    public DbSet<Course> Courses { get; protected init; } = null!;

    public DbSet<Certificate> Certificates { get; protected init; } = null!;

    public DbSet<LessonPassed> LessonsPassed { get; protected init; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        IEnumerable<IMutableForeignKey> cascadeFKs = modelBuilder.Model.GetEntityTypes()
            .SelectMany(t => t.GetForeignKeys())
            .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

        foreach (IMutableForeignKey fk in cascadeFKs)
        {
            fk.DeleteBehavior = DeleteBehavior.Restrict;
        }

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<Points>().HaveConversion<PointsValueConverter>();
        configurationBuilder.Properties<Fraction>().HaveConversion<FractionValueConverter>();
        configurationBuilder.Properties<TimeSpan>().HaveConversion<TimeSpanConverter>();

        configurationBuilder.Properties<SpbDateTime>().HaveConversion<SpbDateTimeValueConverter>();
    }
}
