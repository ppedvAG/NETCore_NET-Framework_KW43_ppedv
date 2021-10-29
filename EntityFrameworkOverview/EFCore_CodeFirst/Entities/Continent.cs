using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_CodeFirst.Entities
{
    public class Continent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Warum ICollection -> lazyLoading benötigt virtual ICollection<Country>
        public virtual ICollection<Country> Countries { get; set; }
    }


}
