using System.Diagnostics.CodeAnalysis;
using Dating_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dating_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}