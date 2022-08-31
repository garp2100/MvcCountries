using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        public void WelcomeAction()
        {
            var continueSelect = "";
            do
            {
                Console.WriteLine(
                    "Hello, welcome to the country app. Which country would you like to learn more about?");
                var view = new CountryListView(CountryDb);
                view.Display();
                Console.WriteLine("Enter 1-" + CountryDb.Count);
                var index = 0;
                var validatedInputed = true;
                do
                {
                    var input = Console.ReadLine();
                    validatedInputed = int.TryParse(input, out index);
                    if (!validatedInputed)
                    {
                        Console.WriteLine("invalid input, please try again");
                        continue;
                    }
                } while (!validatedInputed);
                
                CountryAction(CountryDb[index-1]);
                Console.WriteLine("Would you like to try again? y/n");
                continueSelect = Console.ReadLine();
            }
            while (continueSelect == "y");
        }

        public void CountryAction(Country country)
        {
            var view = new CountryView(country);
            view.Display();
        }
    }
}
