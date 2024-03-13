using Microsoft.EntityFrameworkCore;

namespace Sample.Infrastructure.Persistence.Contexts
{
	public class CourseDbContext : DbContext
	{
		public CourseDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Course> Courses { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Course>()
				.HasKey(c => c.CourseId);

			modelBuilder.Entity<Course>()
				.HasOne(c => c.Author)
				.WithMany()
				.HasForeignKey(c => c.AuthorId);


			base.OnModelCreating(modelBuilder);
		}
	}
}
