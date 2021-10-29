using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET48_DatabaseFirst_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MovieDbContext ctx = new MovieDbContext())
            {
                foreach (Movie currentMovie in ctx.Movie)
                {
                    Console.WriteLine($"{currentMovie.Title} - {currentMovie.Description}");
                }
            }

            Console.ReadLine();
        }
    }
}
