using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
           var ipDictionary = new Dictionary<string, Dictionary<string, int>> ();

            while (true)
            {

                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] commandArgs = line.Split(' ');
                string ip = commandArgs[0].Replace("IP=", "");
                string name = commandArgs[2].Replace("user=", "");

                if (!ipDictionary.ContainsKey(name))
                {
                    ipDictionary.Add(name, new Dictionary<string, int>());

                }
                if (!ipDictionary[name].ContainsKey(ip))
                {
                    ipDictionary[name].Add(ip, 0);
                }
                ipDictionary[name][ip] = ipDictionary[name][ip] + 1;
            }

            foreach (var user in ipDictionary.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key + ": ");

                StringBuilder test = new StringBuilder();

                foreach (var IPandCount in user.Value)
                {
                    test.Append(IPandCount.Key).Append(" => ").Append(IPandCount.Value + ", ");
                }
                test.Remove(test.Length - 2, 2);
                test.Append(".");
                Console.WriteLine(test.ToString());
            }
        }
    }
}
