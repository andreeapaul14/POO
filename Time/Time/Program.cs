using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Time
    {
        private int ore, min, sec, sut;
        public Time(int sut, int sec, int min, int ore)
        {
            this.ore = ore;
            this.min = min;
            this.sec = sec;
            this.sut = sut;
        }
        public Time(string s)
        {
            char[] sep = { ':' };
            string[] x = s.Split(sep);
            if (x.Length == 2)
            {
                this.ore = Convert.ToInt32(x[0]);
                this.min = Convert.ToInt32(x[1]);
                this.sec = Convert.ToInt32(x[2]);
                this.sut = Convert.ToInt32(x[3]);
            }
            else
                if (x.Length == 3)
                {
                    this.ore = Convert.ToInt32(x[0]);
                    this.min = Convert.ToInt32(x[1]);
                    this.sec = Convert.ToInt32(x[2]);
                    this.sut = Convert.ToInt32(x[3]);
                }
            else
                if(x.Length == 4)
                {
                    this.ore = Convert.ToInt32(x[0]);
                    this.min = Convert.ToInt32(x[1]);
                    this.sec = Convert.ToInt32(x[2]);
                    this.sut = Convert.ToInt32(x[3]);
                }
            else
                Console.WriteLine("Ora incorecta!");
        }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0}:{1}:{2}:{3}", ore, min, sec, sut);
            return s.ToString();
        }
        public static int GetSuttimi(Time d)
        {
            int i, sut = 0;
            for (i = 1; i < d.sec; i++)
                sut += 1000;
            for (i = 1; i < d.min; i++)
                sut += 60000;
            for (i = 1; i < d.ore; i++)
                sut += 3600000;
            sut += d.sut;
            return sut;
        }
        public static int operator -(Time d1, Time d2)
        {
            return Math.Abs(GetSuttimi(d1) - GetSuttimi(d2));
        }
        public static int operator +(Time d1, Time d2)
        {
            return GetSuttimi(d1) + GetSuttimi(d2);
        }
        public static bool operator ==(Time d1, Time d2)
        {
            if ((d1.ore == d2.ore) && (d1.min == d2.min) && (d1.sec == d2.sec) && (d1.sut == d2.sut))
                return true;
            return false;
        }
        public static bool operator !=(Time d1, Time d2)
        {
            if (d1 == d2)
                return false;
            return true;
            // return !(d1==d2);
        }
        public static bool operator <(Time d1,Time d2)
        {
            if (d1.ore < d2.ore)
                return true;
            if ((d1.ore == d2.ore) && (d1.min < d2.min))
                return true;
            if ((d1.ore == d2.ore) && (d1.min < d2.min) && (d1.sec < d2.sec))
                return true;
            if ((d1.ore == d2.ore) && (d1.min < d2.min) && (d1.sec < d2.sec) && (d1.sut < d2.sut))
                return true;
            return false;
        }
        public static bool operator <=(Time d1, Time d2)
        {
            if (d1 < d2 || d1 == d2)
                return true;
            return false;
        }
        public static bool operator >(Time d1, Time d2)
        {
            if (d1 <= d2)
                return false;
            return true;
        }
        public static bool operator >=(Time d1, Time d2)
        {
            if (d1 < d2)
                return false;
            return true;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Time d1 = new Time(6,4,5,3);//sutimi, secunde, minute, ore
            Time d2 = new Time(3,4,5,3);
            Console.WriteLine("Timpul1: {0}\nTimpul2: {1}", d1, d2);
            Console.WriteLine("Diferenta dintre cei 2 timpi este de {0} sutimi", d1 - d2);
            if (d1 == d2)
                Console.WriteLine("Orele coincid");
            else
 if (d1 < d2)
                Console.WriteLine("Timpul1 este anterior timpului2");
            else
                Console.WriteLine("Timpul2 este anterior timpului1");

        }
    }
}
