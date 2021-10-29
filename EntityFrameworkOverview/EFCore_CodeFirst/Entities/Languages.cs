using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_CodeFirst.Entities
{
    public class Languages
    {
        public int Id { get; set; }
        public int Name { get; set; }

        public virtual ICollection<CountryLanguages> CountryLanguages { get; set; }

    }
}
