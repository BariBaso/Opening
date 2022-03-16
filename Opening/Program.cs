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
        }
    }
}
