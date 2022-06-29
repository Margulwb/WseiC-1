using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjektyMG
{
    public class UserDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = DataFile.db");
        }

        public DbSet<User> User { get; set; }
    }
}

public class User
{
    [Key]
    public long ID { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public List<Workers> Workers { get; } = new();
}
