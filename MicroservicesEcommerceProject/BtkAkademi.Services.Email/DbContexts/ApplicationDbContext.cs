using BtkAkademi.Services.Email.Models;
using Microsoft.EntityFrameworkCore;

namespace BtkAkademi.Services.Email.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<EmailLog> EmailLogs { get; set; }

    }
}
