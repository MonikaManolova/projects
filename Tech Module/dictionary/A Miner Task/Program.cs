using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
    class Program
    {
        static void Main()
        {
            var resources = new Dictionary<string, int>();

            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource,0);
                }

                resources[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
