using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Travel.Models
{
    public class TravelDbContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(GetConnectionString());
        }
        
        private static string GetConnectionString()
        {
            const string databaseName = "travel";
            const string databaseUser = "root";
            const string databasePass = "1";
            
            return $"Server=localhost;" +
                   $"database={travel};" +
                   $"uid={root};" +
                   $"pwd={epicodus};" +
                   $"pooling=true;";
        }
    }
}