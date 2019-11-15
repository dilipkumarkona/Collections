using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

          

            Country CountryOne = new Country("India", "Ind");
            Country CountryTwo = new Country("UnitedStates", "USA");

            Dictionary<string, Country> countries = new Dictionary<string, Country>

            {
                { CountryOne.Code, CountryOne },
                { CountryTwo.Code, CountryTwo }
            };

            bool exist = countries.TryGetValue("ind", out Country country);
            if (exist)
                Console.WriteLine(countries["ind"]);
           // Console.WriteLine(countries["TT"].Name);


            //foreach (Country country in countries.Values)
            //{
            //    Console.WriteLine(country.Name);
            //}
          //  var country = countries["Ind"];
            //List<string> daysOfWeek = new List<string>
            //{
            //    "MonDay",
            //    "TuesDay",
            //    "WednesDay",
            //    "Thursday"
            //};

            //CsvReader reader = new CsvReader(@"C:\Personal\test.txt");

            ////  Country[] counties = reader.ReadTopNCountries(2);

            //var countries = reader.CountriesList();
            //foreach (Country country in countries)
            //{
            //    Console.WriteLine($"Name - {country.Name} & Code - {country.Code}" );
            //}

            ////for (int i = 0; i < counties.Length; i++)
            ////{

            ////    //Console.WriteLine("Name {0}", counties[i].Name);
            ////}
            Console.ReadKey();

        }
    }
}
