using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Opening
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Class1> weakend = new List<Class1>();
            foreach (var sor in File.ReadAllLines("nyitohetvege.txt").Skip(1))
            {
                weakend.Add(new Class1(sor));
            }

            //3.
            Console.WriteLine($"3.feladat: filmek száma az állományban: {weakend.Count} db");
            //4.
            Console.WriteLine($"4. feladat: az UIP Duna Film forgalmazo 1. hetes bevételének öszege: {weakend.Where(x => x.forgalmazó == "UIP").Sum(x => (long)x.bevel)} Ft");
            //5.
            Class1 sss = weakend.OrderByDescending(x => x.latogato).First();
            Console.WriteLine("5. feladat: Legtöbb látogató az első  héten:");
            Console.WriteLine($"\tEredeti cím: {sss.EredetiCím} másodperc");
            Console.WriteLine($"\tMagyar cím: {sss.MagyarCím}");
            Console.WriteLine($"\tForgalmazó: {sss.forgalmazó}");
            Console.WriteLine($"\tBevétel az első héten: {sss.bevel} Ft");
            Console.WriteLine($"\tLátogatók száma: {sss.latogato}$");
            //6.
            bool van = weakend.Any(x => x.EredetiCím.ToLower().Split(' ').All(y => y.ToLower().First() == 'W') && x.MagyarCím.ToLower().Split(' ').All(y => y.ToLower().First() == 'W'));
            Console.WriteLine($"6. feladat: {(van ? "japp" : "nop" )}");
        }
    }
}
