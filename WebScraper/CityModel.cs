using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper
{
    internal class CityModel
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public CityModel(string code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
