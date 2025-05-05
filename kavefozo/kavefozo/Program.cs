using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kavefozo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kavefozo kave = new Kavefozo();

            kave.foz();

            kave.feltolt("viz", 10);
            kave.feltolt("kave", 6);

            kave.foz();

            kave.ranez();

            kave.kiont();

            Console.WriteLine(kave.Edeny.Minoseg);

            kave.feltolt("kave", 3);

            kave.kiurit("kave");

            kave.feltolt("kave", 6);

            kave.foz();

            kave.ranez();

            kave.kostol();

            //Console.ReadLine();

        }
    }
}
