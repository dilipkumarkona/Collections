using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class CsvReader
    {
        private string _csVFilePath;
        public CsvReader(string csvFilePath)
        {
            _csVFilePath = csvFilePath;                
        }

        public Country[] ReadTopNCountries(int numberOfCountries)
        {
            Country[] countries = new Country[numberOfCountries];
            using (StreamReader sr = new StreamReader(_csVFilePath))
            {
                for (int i = 0; i < numberOfCountries; i++)
                {

                    string readLine = sr.ReadLine();
                    countries[i] = ReadConunties(readLine);
                }
            }
            return countries;
        }

        public List<Country> CountriesList()
        {
            List<Country> countries = new List<Country>();

            using (StreamReader sr = new StreamReader(_csVFilePath))
            {
                string strLine;
                while ((strLine = sr.ReadLine()) != null)
                {
                    countries.Add(ReadConunties(strLine));
                }
                
            }

            return countries;
        }
        public Country ReadConunties(string csvLine)
        {
            string[] part = csvLine.Split(',');

            return new Country(part[0], part[1]);
        }
    }
}
