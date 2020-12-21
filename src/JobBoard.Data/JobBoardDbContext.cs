using JobBoard.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace JobBoard.Data
{
    public class JobBoardDbContext : DbContext
    {
        public JobBoardDbContext(DbContextOptions<JobBoardDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Customer> Customers { get; set; }
    }
}