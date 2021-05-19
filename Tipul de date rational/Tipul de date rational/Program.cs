using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipul_de_date_rational
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational a = new Rational(6, 4);
            a.print();
            Rational b = new Rational(100, 25);
            b.print();
            Console.WriteLine("Forma ireductibila");
            a.forma_ireductibila();      
            b.forma_ireductibila();
            Console.WriteLine("Adunarea fractiilor");
            Operator.adunare(a,b);
            Console.WriteLine("Scaderea fractiilor");
            Operator.scadere(a,b);
            Console.WriteLine("Inmultirea fractiilor");
            Operator.imultire(a,b);  
            Console.WriteLine("Impartirea fractiilor");
            Operator.impartire(a,b);
            Console.WriteLine("Sunt fractiile egale?");    
            System.Console.WriteLine(Operator.logic_operators("=", a, b));
            
        }
    }
}
