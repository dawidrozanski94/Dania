using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DanieGlowne : Danie
    {
        public DanieGlowne(string nazwa, double cena): base(nazwa, cena)
        {

        }

        public override void Info()
        {
            Console.WriteLine("Danie główne:");
            base.Info();
        }
    }
}
