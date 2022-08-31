using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCountries
{
    public class CountryController
    {
        public List<Country> CountryDb { get; set; } = new List<Country>()
        {
            new Country(
                "USA",
                "North America",
                new List<string>(){"red", "white", "blue"}
                ),
            new Country(
                "Venezuela",
                "South America",
                new List<string>(){"yellow", "blue", "red"}
            ),
        };

        public void CountryAction(Country c)
        {
            
        }

        public void WelcomeAction()
        {
            var view = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app. Which country would you like to learn more about?");
            view.Display();
            Console.WriteLine("Enter 1-" + CountryDb.Count);
        }
    }
}
