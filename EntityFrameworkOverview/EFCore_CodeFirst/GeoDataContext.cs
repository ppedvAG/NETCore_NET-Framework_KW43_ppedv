using EFCore_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_CodeFirst
{
    public class GeoDataContext : DbContext
    {

        //In ASP.NET Core - in Verbindung mit ServiceCollection / ServiceProvider
        //public GeoDataContext(DbContextOptions<GeoDataContext> dbContextOptions)
        //{

        //}

        public GeoDataContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyHollywoodMovieDB;Trusted_Connection=True;Integrated Security=True;");
        }

        public DbSet<Continent> Continents { get; set; }

        public DbSet<Country> Countries { get; set; }
    }
}
