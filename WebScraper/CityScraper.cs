using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper
{
    internal class CityScraper
    {
        public string Name { get; set; }

        public IEnumerable<CityModel> GetCities(CountryModel country)
        {
            var web = new HtmlWeb();
            var document = web.Load(country.Href);

            var tableRows = document.QuerySelectorAll("body > table:nth-child(3) tr").Skip(1);

            foreach ( var row in tableRows )
            {
                var tds = row.QuerySelectorAll("td");

                var code = tds[1].InnerText;
                var name = tds[2].InnerText;

                yield return new CityModel(code, name);
            }
        }
    }
}
