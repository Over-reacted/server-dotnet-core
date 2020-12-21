using System.IO;
using JobBoard.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<JobBoardDbContext>
{
    public JobBoardDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<JobBoardDbContext>();

        var connectionString = configuration.GetConnectionString("DefaultConnection");
        builder.UseMySQL(connectionString);

        return new JobBoardDbContext(builder.Options);
    }
}