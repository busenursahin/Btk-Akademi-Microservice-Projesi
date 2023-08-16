using BtkAkademi.Service.ShoppingCartAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BtkAkademi.Service.ShoppingCartAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartHeader> CartHeaders { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }

    }
}
