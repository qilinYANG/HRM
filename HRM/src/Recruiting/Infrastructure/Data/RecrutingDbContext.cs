

using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
	public class RecrutingDbContext : DbContext
	{
		public RecrutingDbContext(DbContextOptions<RecrutingDbContext> options): base(options)
		{
		}

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<JobStatusLookUp> JobStatusLookUps { get; set; }
        public DbSet<Submission> Submissions { get; set; }
    }
}

