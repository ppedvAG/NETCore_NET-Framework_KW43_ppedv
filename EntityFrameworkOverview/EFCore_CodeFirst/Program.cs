using EFCore_CodeFirst.Entities;
using System;
using System.Linq;

namespace EFCore_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (GeoDataContext context = new())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    Continent continent = new Continent()
                    {
                        Name = "Asien"
                    };

                    Continent continent2 = new Continent()
                    {
                        Name = "Australien"
                    };

                    context.Continents.Add(continent2);
                    context.Continents.Add(continent); // Hier wird intern vermekt, dass continent hinzugefügt werden soll
                    context.SaveChanges(); // SQL generiert und richtung DB gesendet. 



                    transaction.Commit();
                }




               
            }



            using (GeoDataContext context = new())
            {
                Continent currentContonent = context.Continents.SingleOrDefault(n => n.Id == 2);
                currentContonent.Name = "Afrika";

                context.Continents.Update(currentContonent);
                context.SaveChanges();
            }
        }
    }
}
