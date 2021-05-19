using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numere_complexe
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(2, -3);
            Complex b = new Complex(1, 4);
            a.print();
            b.print();
            Operator.adunare(a, b); //exceptie forma trigonometrica este implementata in Complex
            Operator.scadere(a, b);
            Operator.imultire(a, b); //operator class raspunde de operatii cu numre complexe
            a.forma_trigonometrica();

        }
    }
}
