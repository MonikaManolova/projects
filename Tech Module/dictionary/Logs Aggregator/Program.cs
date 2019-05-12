using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var logs = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            while (n-- > 0)
            {
                string line = Console.ReadLine();

                var commandArgs = line.Split(' ');
                string ip = commandArgs[0];
                string name = commandArgs[1];
                int logsCount = int.Parse(commandArgs[2]);

                if (!logs.ContainsKey(name))
                {
                    logs.Add(name, new Dictionary<string, int>());
                }
                if (!logs[name].ContainsKey(ip))
                {
                    logs[name].Add(ip, logsCount);
                }
                else
                {
                    logs[name][ip] = logs[name][ip] + logsCount;
                }
            }

            foreach (var name in logs.OrderBy(x => x.Key))
            {
                Console.Write($"{name.Key}: {name.Value.Values.Sum()} ");

                StringBuilder print = new StringBuilder();
                print.Append("[");

                foreach (var log in name.Value.OrderBy(i => i.Key))
                {
                    print.Append(log.Key).Append(", ");
                }
                print.Remove(print.Length - 2, 2);
                print.Append("]");
                Console.Write(print.ToString());
                Console.WriteLine();
            }
        }
    }
}
