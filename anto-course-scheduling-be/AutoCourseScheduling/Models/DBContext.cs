using AutoCourseScheduling.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoCourseScheduling.Models
{
	public class DBContext : DbContext
	{
		public DBContext(DbContextOptions<DBContext> options): base(options){}
		public DbSet<Teacher> Teachers { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var serverVersion = new MySqlServerVersion(new Version(5, 7, 39));
			optionsBuilder.UseMySql("Server=127.0.0.1;port=3306;Database=test;uid=root;pwd=qunma;Character Set=utf8;", serverVersion);
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
		}

	

	}
}
