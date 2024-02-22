using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v = Vector.Parse("5;3");
            Console.WriteLine(v.Versore());
            Console.ReadLine();

        }
    }
}
