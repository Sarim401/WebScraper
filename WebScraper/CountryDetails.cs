using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper
{
    internal class CountryDetails
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public IEnumerable<CityModel> Cities { get; set; }
    }
}
