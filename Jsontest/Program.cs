using System;
using Microsoft.AspNetCore.Http.Features;
using razor2.Services;
    
namespace Jsontest
{
    class Program
    {
        static void Main(string[] args)
        {
            var portfolios = new PortfolioServiceJsonFile().GetPortfolios();
            foreach (var item in portfolios){
                Console.WriteLine(item);
            }
        }
    }
}