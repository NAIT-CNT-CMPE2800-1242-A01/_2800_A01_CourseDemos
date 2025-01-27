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

                /*
                t: 15
                a: 13
                c: 6
                o: 5
                p: 4
                n: 4
                b: 3
                f: 2
                x: 2
                i: 2
                m: 1
                s: 1
                e: 1
                k: 1
                */
            }

            {
                // question #02
                // Group the words by their last two characters, case insensitive,
                //  showing all the words in that grouping, ordered by grouping

                /*
                an : can, tan, pan
                at : cat, Cat, cAt, caT, CAT, bat, mat, sAt, faT, eAT
                it : bit, kit
                op : top, pop
                ot : not
                ox : box, fox
                */
            }

            Console.ReadKey();
        }
    }
}
