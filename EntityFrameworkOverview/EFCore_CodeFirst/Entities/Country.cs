using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_CodeFirst.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Capital City")]
        public string CapitalCity { get; set; }

        
        
        //Navigation FK + Navigation Object
        public int ContinentId { get; set; } //FK zu Continent 

        public virtual Continent ParentContinent { get; set; }


        public virtual ICollection<CountryLanguages> CountryLanguages { get; set; }
    }
}
