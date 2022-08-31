using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCountries
{
    public class Country
    {
        public Country()
        {
                
        }

        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Ingredients { get; set; }

    }
}
