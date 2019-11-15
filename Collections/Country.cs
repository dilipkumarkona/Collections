using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int Population { get; set; }

        public Country(string name, string code)
        {
            Name = name;
            Code = code;
        }
    }
}
