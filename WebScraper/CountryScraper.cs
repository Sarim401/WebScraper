using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper
{
    internal class CountryScraper
    {
        private const string baseUrl = "https://unece.org/trade/cefact/unlocode-code-list-country-and-territory";
        public IEnumerable<CountryModel> GetCountries()
        {
            var web = new HtmlWeb();
            var document = web.Load(baseUrl);

            var tableRows = document.QuerySelectorAll("table tr").Skip(1);

            foreach( var row in tableRows )
            {
                var tds = row.QuerySelectorAll("td");

                var code = tds[0].InnerText;
                var country = tds[1].InnerText;

                var href = tds[1].QuerySelector("a").Attributes["href"].Value;

                yield return new CountryModel(code, country, href);
            }
        }
    }
}
