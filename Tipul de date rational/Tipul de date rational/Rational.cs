using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipul_de_date_rational
{
    public class Rational
    {

        public int numitor;
        public int numarator;

        public Rational(int numarator, int numitor)
        {
            this.numarator = numarator;
            this.numitor = numitor;
        }
        public Rational() { }
        public Rational(int numarator)
        {
            this.numarator = numarator;
            this.numitor = 1;
        }
        public void print()
        {
            System.Console.Write($"{numarator}/{numitor}");
            System.Console.WriteLine();
        }
        public void forma_ireductibila()
        {
            int tmp = Operator.cmmc(numarator, numitor);
            if(tmp!=0)
            {
                numarator /= tmp;
                numitor /= tmp;
            }
            print();
        }
    }
    public static class Operator
    {
        private static void amplificare(Rational a, Rational b)
        {
            a.numarator *= b.numitor;
            b.numarator *= a.numitor;
            a.numitor *= b.numitor;
            b.numitor *= a.numitor;

        }
        public static void adunare(Rational a, Rational b)
        {
            Rational result = new Rational();
            if (a.numitor == b.numitor)
            {
                result.numitor = a.numitor;
                result.numarator = a.numarator + b.numarator;
                int tmp = cmmc(result.numitor, result.numarator);
                result.numarator /= tmp;
                result.numitor /= tmp;
            }
            else
            {
                amplificare(a, b);
                result.numitor = a.numitor;
                result.numarator = a.numarator + b.numarator;
                int tmp = cmmc(result.numitor, result.numarator);
                result.numarator /= tmp;
                result.numitor /= tmp;
            }
            _print(result);
        }
        public static void scadere(Rational a, Rational b)
        {
            Rational result = new Rational();
            if (a.numitor == b.numitor)
            {
                result.numitor = a.numitor;
                result.numarator = a.numarator - b.numarator;
               
            }
            else
            {
                amplificare(a, b);
                result.numitor = a.numitor;
                result.numarator = a.numarator - b.numarator;
                
            }
            _print(result);
        }
        public static void imultire(Rational a, Rational b)
        {
            Rational result = new Rational();
            result.numarator = a.numarator * b.numarator;
            result.numitor = a.numitor * b.numitor;
            int tmp = cmmc(result.numitor, result.numarator);
            result.numarator /= tmp;
            result.numitor /= tmp;
            _print(result);
        }
        public static void impartire(Rational a, Rational b)
        {
            int tmp;
            tmp = b.numarator;
            b.numarator = b.numitor;
            b.numitor = tmp;
            imultire(a, b);
        }
        public static int cmmc(int a, int b)
        {
            int x = a, y = b, mult;//multiplu
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            mult = y;
            return mult;
        }
        private static void _print(Rational number)
        {
            System.Console.WriteLine($"{number.numarator}/{number.numitor}");
        }
        public static bool logic_operators(string semnul_logic, Rational a, Rational b)
        {
            bool result = false;
            switch (semnul_logic)
            {
                case "=":
                    {
                        if (a.numarator == b.numarator && a.numitor == b.numitor) return true;
                        else return false;
                    }
                case ">":
                    {
                        if (a.numarator > b.numarator && a.numitor == b.numitor) return true;
                        else if (a.numitor < b.numitor) return true;
                        else return false;
                    }
                case "<":
                    {
                        if (a.numarator < b.numarator && a.numitor == b.numitor) return true;
                        else if (a.numitor > b.numitor) return true;
                        else return false;
                    }
                case "!=":
                    {
                        if (a.numarator != b.numarator || a.numitor != b.numitor) return true;
                        else return false;
                    }
                case "<=":
                    {
                        if (a.numarator <= b.numarator && a.numitor == b.numitor) return true;
                        else if (a.numitor >= b.numitor) return true;
                        else return false;
                    }
                case ">=":
                    {
                        if (a.numarator >= b.numarator && a.numitor == b.numitor) return true;
                        else if (a.numitor <= b.numitor) return true;
                        else return false;
                    }
            }
            return result;
        }
    }
}
