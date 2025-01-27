// basic demo of LINQ syntax and layout

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                List<int> list = new List<int>(new int[] { 2, 5, 6, 7, 10, 123, 1054, 91, 1 });
                var res =       // typical use of var (return type is weird, and changes with query)
                    from q in list
                        orderby q   // oddly, order by can go here - sort prior to grouping
                        group q
                        by (int)Math.Floor(Math.Log10(q) + 1) // note: can be calculated
                        into s      // capture result into temp
                            orderby s.Key descending
                            select s;
                res.ToList().ForEach(q =>
                {
                    Console.WriteLine($"Number with {q.Key} digit(s): ");
                    q.ToList().ForEach(v => Console.WriteLine($"\t{v}"));
                });
            }

            {
                // let clause
                List<int> stuff = new List<int>(new int[] { 1, 2, 3 });
                var res =
                    from q in stuff                         // view as outer loop
                        let small = stuff.Select (p=>p)     // simple, but a collection
                        from x in small                     // view as inner loop
                            select (q, x, q * x);
                Console.Write("\r\n\r\nFinal numbers : ");
                Console.WriteLine (string.Join(", ", res));
            }

            {
                // let clause
                List<int> stuff = new List<int>(new int[] { 1, 3, 4, 6, 7, 9, 10 });
                var res =
                    from q in stuff
                    let avg = Math.Round (stuff.Average(), 2) // pretend this is computationally expensive
                    where q < avg
                    select new { a = avg, v = q };

                Console.Write("\r\n\r\nSmaller than average : ");
                Console.WriteLine (string.Join (", ", res));
            }

            {
                // grouping
                string[] words = "This is a test of the <~~~> early warning system!".Split(new char[] { ' ' });
                var res =
                    from word in words
                    let firstvowel = word.FirstOrDefault((w) => "AEIOUaeiou".Contains(w))                    
                    group word by firstvowel;                    

                Console.Write("\r\n\r\nGrouped by vowel : ");
                
                // with non vowel group
                foreach (var gp in res)

                // without non vowel group
                //foreach (var gp in res.Where (q=>q.Key != new char()))
                {
                    Console.Write($"Vowel : '{gp.Key}' : ");
                    Console.WriteLine(string.Join(" ", gp));                        
                };
            }

            Console.ReadKey();
        }
    }
}
