using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Azure.Core;
using Microsoft.AspNetCore.Hosting;
using razor2.Models;

namespace razor2.Services
{
    public class PortfolioServiceJsonFile
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        
        public PortfolioServiceJsonFile(IWebHostEnvironment webHostEnvironment)
        {
            this._webHostEnvironment = webHostEnvironment;
        }

        private string JSonFileName {
            get
            {
                // return _webHostEnvironment.WebRootPath + "\\Portfolios" + "\\portfolios.json";
                return Path.Combine(_webHostEnvironment.WebRootPath, "Portfolios", "portfolios.json");
            }
        }

        public IEnumerable<Portfolio> GetPortfolios()
        {
            var jsonFileName = @"/Users/richie/RiderProjects/razorPages/razor2/wwwroot/Portfolios/portfolios.json";

            using (var jsonFileReader = File.OpenText(JSonFileName))
            {
                var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                var aa = JsonSerializer.Deserialize<Portfolio[]>(jsonFileReader.ReadToEnd(), options);
                return aa;
            }
        }
    }  
}