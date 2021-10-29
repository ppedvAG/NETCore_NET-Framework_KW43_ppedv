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
        public GeoDataContext()
        {

        }


        public DbSet<Continent> Continents { get; set; }

        public DbSet<Country> Countries { get; set; }
    }
}
