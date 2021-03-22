using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Time
{
    class Program
    {
        public Program(int ore, int min, int sec)
        {
            this.ore= ore;
            this.min = min;
            this.sec= sec;
        }
        public Program(string s)
        {
            char[] separator = { '.', ':' };
            string[] x = s.Split(separator);
            if (x.Length != 3)
                Console.WriteLine("Ora incorecta!");
            else
            {
                this.ora = Convert.ToInt32(x[0]);
                this.min = Convert.ToInt32(x[1]);
                this.sec = Convert.ToInt32(x[2]);
            }
        }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0}.{1}.{2}", ora, min, sec);
            return s.ToString();
        }
        public static int GetHour(Program d)
        {
            int i, sec = 0;
            for (i = 1; i < d.an; i++)
                sec += (DateTime.IsLeapYear(i)) ? 366 : 365;
            for (i = 1; i < d.luna; i++)
                zile += DateTime.DaysInMonth(d.an, i);
            zile += d.zi;
            return zile;
        }
        public static int operator -(Date d1, Date d2)
        {
            return Math.Abs(GetDays(d1) - GetDays(d2));
        }
        public static bool operator ==(Date d1, Date d2)
        {
            if ((d1.an == d2.an) && (d1.luna == d2.luna) && (d1.zi == d2.zi))
                return true;
            return false;
        }
        public static bool operator !=(Date d1, Date d2)
        {
            if (d1 == d2)
                return false;
            return true;
            // return !(d1==d2);
        }
        public static bool operator <(Date d1, Date d2)
        {
            if (d1.an < d2.an)
                return true;
            if ((d1.an == d2.an) && (d1.luna < d2.luna))
                return true;
            if ((d1.an == d2.an) && (d1.luna == d2.luna) && (d1.zi < d2.zi))
                return true;
            return false;
        }
        public static bool operator <=(Date d1, Date d2)
        {
            if (d1 < d2 || d1 == d2)
                return true;
            return false;
        }
        public static bool operator >(Date d1, Date d2)
        {
            if (d1 <= d2)
                return false;
            return true;
        }
        public static bool operator >=(Date d1, Date d2)
        {
            if (d1 < d2)
                return false;
            return true;
        }
        private int zi, luna, an;
    }
    class Test
    {
        static void Main()
        {
            Program d1 = new Program(15, 04, 2021);
            Program d2 = new Program(15, 02, 2021);
            Console.WriteLine("data1: {0}\ndata2: {1}", d1, d2);
            Console.WriteLine("diferenta dintre cele doua date este de {0} zile", d1 - d2);
            if (d1 == d2)
                Console.WriteLine("datele coincid");
            else
            if (d1 < d2)
                Console.WriteLine("data1 este anterioara datei2");
            else
                Console.WriteLine("data2 este anterioara datei1");
        }
    }
}
