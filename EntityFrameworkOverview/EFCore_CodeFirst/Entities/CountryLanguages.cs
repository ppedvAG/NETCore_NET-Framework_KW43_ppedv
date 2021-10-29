using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_CodeFirst.Entities
{
    public class CountryLanguages
    {
        public int Id { get; set; }

        public int Percent { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country {get;set;}


        public int LanguageId { get; set; }
        public virtual Languages Languages { get; set; }
    }
}
