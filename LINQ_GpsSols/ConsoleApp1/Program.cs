using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static Random _rnd = new Random();

        private static readonly string[] _strdata = new string[]
        {
            "cat", "Cat", "cAt", "caT", "CAT",
            "bat", "mat", "sAt", "faT", "eAT",
            "box", "top", "not", "bit", "can",
            "kit", "pop", "fox", "tan", "pan"
        };

        static void Main(string[] args)
        {
            {
                // Question #01
                // Show how many times each letter appears, case insensitive
                // in descending order of count
                var res = from word in _strdata
                          let lwords = word.ToLower()
                          from lchar in lwords
                          group lchar by lchar
                          into gps
                          orderby gps.Count() descending
                          select gps;

                foreach (var gp in res)
                {
                    Console.WriteLine($"{gp.Key} : {gp.Count()}");
                }
            }

            // question #02
            // Group the words by their last two characters, case insensitive,
            //  showing all the words in that grouping, ordered by grouping
            {
                var res = from word in _strdata
                          group word by word.Substring(1).ToLower()
                into gps
                          orderby gps.Key
                          select gps;

                foreach (var gp in res)
                {
                    Console.WriteLine($"{gp.Key} : {string.Join(", ", gp)}");
                }
            }
            Console.ReadKey();
        }
    }
}
