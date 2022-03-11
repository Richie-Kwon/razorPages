using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using razor2.Models;

namespace razor2.Services
{
    public class PortfolioServiceJsonFile
    {
        public IEnumerable<Portfolio> GetPortfolios()
        {
            var jsonFileName = @"/Users/richie/RiderProjects/razorPages/razor2/wwwroot/Portfolios/portfolios.json";

            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                var AA=JsonSerializer.Deserialize<Portfolio[]>(jsonFileReader.ReadToEnd(),options);
                return AA;
            }

            
        }
    }
}