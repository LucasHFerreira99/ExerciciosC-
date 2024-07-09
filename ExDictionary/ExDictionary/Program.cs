using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
namespace ExDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> voting = new Dictionary<string, int>();


            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(",");
                        string name = line[0];
                        int qtd = int.Parse(line[1]);
                        if(voting.ContainsKey(name))
                        {
                            voting[name] += qtd;
                        }
                        else
                        {
                            voting[name] = qtd;
                        }
                    }

                    foreach (var item in voting)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}