using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numere_complexe
{
    public class Complex
   
        {
            public int parte_reala;
            public int parte_imaginara;
            public Complex() { }
            public Complex(int parte_reala, int parte_imaginara)
            {
                this.parte_reala = parte_reala;
                this.parte_imaginara = parte_imaginara;
            }
            public Complex(int parte_reala)
            {
                this.parte_reala = parte_reala;
                parte_imaginara = 0;
            }
            public void print()
            {
                if (parte_imaginara > 0)
                    System.Console.WriteLine($"{parte_reala}+{parte_imaginara}i");
                else System.Console.WriteLine($"{parte_reala}{parte_imaginara}i");
                if (parte_imaginara == 0)
                    System.Console.WriteLine(parte_reala);
                if (parte_reala == 0)
                    System.Console.WriteLine(parte_imaginara + "i");
            }
            public void forma_trigonometrica()
            {
                float r; float teta;
                r = (float)Math.Sqrt(parte_reala * parte_reala + parte_imaginara * parte_imaginara);
                teta = (float)Math.Atan(parte_imaginara / parte_reala);
                System.Console.WriteLine($"forma trigonometrica : {r}(cos {teta} + i sin {teta})");
            }
        }
        public static partial class Operator
        {

            public static void adunare(Complex number1, Complex number2)
            {
                Complex result = new Complex();
                result.parte_reala = number1.parte_reala + number2.parte_reala;
                result.parte_imaginara = number1.parte_imaginara + number2.parte_imaginara;
                _print(result);
            }
            public static void scadere(Complex number1, Complex number2)
            {
                Complex result = new Complex();
                result.parte_reala = number1.parte_reala - number2.parte_reala;
                result.parte_imaginara = number1.parte_imaginara - number2.parte_imaginara;
                _print(result);
            }
            private static void _print(Complex x)
            {
                if (x.parte_imaginara > 0)
                    System.Console.WriteLine($"{x.parte_reala}+{x.parte_imaginara}i");
                else System.Console.WriteLine($"{x.parte_reala}{x.parte_imaginara}i");
                if (x.parte_imaginara == 0)
                    System.Console.WriteLine(x.parte_reala);
                if (x.parte_reala == 0)
                    System.Console.WriteLine(x.parte_imaginara + "i");
            }
            private static void _print(Complex x, int powerOfI)
            {
                switch (powerOfI)
                {
                    case 2:
                        {
                            if (x.parte_imaginara > 0)
                                System.Console.WriteLine($"{x.parte_reala}+{x.parte_imaginara}");
                            else System.Console.WriteLine($"{x.parte_reala}+{x.parte_imaginara}i");
                            if (x.parte_imaginara == 0)
                                System.Console.WriteLine(x.parte_reala);
                            if (x.parte_reala == 0)
                                System.Console.WriteLine(x.parte_imaginara);
                            break;
                        }
                    case 4:
                        {
                            if (x.parte_imaginara > 0)
                                System.Console.WriteLine($"{x.parte_reala}-{x.parte_imaginara}");
                            else System.Console.WriteLine($"{x.parte_reala}+{x.parte_imaginara}i");
                            if (x.parte_imaginara == 0)
                                System.Console.WriteLine(x.parte_reala);
                            if (x.parte_reala == 0)
                                System.Console.WriteLine(x.parte_imaginara);
                            break;
                        }

                }
            }
            public static void imultire(Complex number1, Complex number2)
            {
                Complex result = new Complex();
                result.parte_reala = number1.parte_reala * number2.parte_reala - number1.parte_imaginara * number2.parte_imaginara;
                result.parte_imaginara = number1.parte_reala * number2.parte_imaginara - number2.parte_reala * number1.parte_imaginara;
                result.parte_imaginara = Math.Abs(result.parte_imaginara);
                _print(result);
            }
       
    }
}
