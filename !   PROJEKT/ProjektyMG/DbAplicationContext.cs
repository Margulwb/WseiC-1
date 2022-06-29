using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DbAplicationContext : DbContext
{
    public DbSet<Users> Users { get; set; }
    public DbSet<Workers> Workers{ get; set; }
    public DbSet<Bike> Bike { get; set; }
    public DbSet<ModelBike> ModelBike { get; set; }

    //public string ConnectionString { get; }

    //public DbAplicationContext(string connectionString)
    //{
    //    this.ConnectionString = connectionString;
    //}

    //protected override void OnConfiguring(DbContextOptionsBuilder options)
    //{
    //    options.UseSqlServer(this.ConnectionString);
    //}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = DataFile.db");
    }
}

public class Users
{
    public long ID { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }  

    public List<Workers> Workers { get; } = new();
}

public class Workers
{
    public long ID { get; set; }
    public string Name { get; set; }    
    public int Seniority { get; set; }
    public int Age { get; set; }
    public int Phone { get; set; }  
    public int UserID { get; set; }
    public Workers workers { get; set; }

    public List<Bike> Bike { get; } = new();
}

public class Bike
{
    public long ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public long WhoPrepared { get; set; }
    public List<ModelBike> ModelBike { get; } = new();
}

public class ModelBike
{
    public long ID { get; set; }
    public string Mark { get; set; }
    public double WheelSize { get; set; }
    public int NumberGears { get; set; }
    public long BikeID { get; set; }
}