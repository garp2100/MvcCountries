using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCountries
{
    public class CountryView
    {
        public CountryView(Country country)
        {
            DisplayCountry = country;
        }
        public Country DisplayCountry { get; set; }

        public void Display()
        {

        }
    }
}
