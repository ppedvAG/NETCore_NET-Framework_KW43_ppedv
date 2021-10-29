using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_CodeFirst.Entities
{
    public class Continent
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        //Warum ICollection -> lazyLoading benötigt virtual ICollection<Country>
        public virtual ICollection<Country> Countries { get; set; }
    }


}
