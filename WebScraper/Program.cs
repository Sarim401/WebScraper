using Newtonsoft.Json;
using System.Text.Json;
using WebScraper;

var countryScraper = new CountryScraper();

var countries = countryScraper.GetCountries();

var cityScraper = new CityScraper();

var result = new List<CountryDetails>();

foreach (var country in countries)
{
    Console.WriteLine($"Getting cities for {country.Name}");
    var cities = cityScraper.GetCities(country);

    result.Add(new CountryDetails()
    {
        Name = country.Name,
        Code = country.Code,
        Cities = cities,
    });
}
Console.WriteLine("Finished");
string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
string fileName = "result.json";
string filePath = Path.Combine(directoryPath, fileName);
var json = JsonConvert.SerializeObject(result);
File.WriteAllText(filePath, json);