using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022_04_04_Rostokk
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RostokAdatok> rostokAdatoks = new List<RostokAdatok>();
            foreach (var sor in File.ReadAllLines("rostok.txt").Skip(1)) 

            {
                rostokAdatoks.Add(new RostokAdatok(sor));
            }
            Console.WriteLine($"3.feladat:{rostokAdatoks.Count}");

            Console.ReadKey();
        }

    }

}
