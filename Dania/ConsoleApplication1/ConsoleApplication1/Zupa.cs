using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Zupa : Danie
    {
        public Zupa(string nazwa, double cena) : base(nazwa, cena)
        {

        }

        public override void Info()
        {
            Console.WriteLine("Zupa:");
            base.Info();
        }
    }
}
