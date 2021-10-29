using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_CodeFirst.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
        
        //Navigation FK + Navigation Object
        public int ContinentId { get; set; } //FK zu Continent 

        public virtual Continent ParentContinent { get; set; }
    }
}
