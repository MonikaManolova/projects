using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalPopulationDict = new Dictionary<string, Dictionary<string, long>>();


            while (true)
            {
                string line = Console.ReadLine();
                if (line == "report")
                {
                    break;
                }

                string[] commandArgs = line.Split('|');
                string city = commandArgs[0];
                string country = commandArgs[1];
                long population = long.Parse(commandArgs[2]);

                if (!totalPopulationDict.ContainsKey(country))
                {
                    totalPopulationDict.Add(country, new Dictionary<string, long>());
                    totalPopulationDict[country].Add(city, population);
                }
                else
                {
                    if (!totalPopulationDict[country].ContainsKey(city))
                    {
                        totalPopulationDict[country].Add(city, population);
                    }
                }

            }
            foreach (var cntry in totalPopulationDict.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{cntry.Key} (total population: {cntry.Value.Values.Sum()})");

                foreach (var cty in cntry.Value.OrderByDescending(n => n.Value))
                {
                    Console.WriteLine($"=>{cty.Key}: {cty.Value}");
                }
            }

        }
    }
}
