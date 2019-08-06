using System;

namespace otomat
{
    class Program
    {
        static void Main(string[] args)
        {
            //d0("aşk");
            Console.Write(otomat("şoför"));
            Console.ReadLine();

        }

        public static void d0(string a)
        {
            if (a.Substring(0, 1).Equals("a"))
            {
                d1(a);
            }
            else
            {
                d0(a);
            }
        }
        public static void d1(string s)
        {
            if (s.Substring(1, 1).Equals("ş"))
            {
                d2(s);
            }
            else
            {
                d0(s);
            }
        }
        public static void d2(string k)
        {
            if (k.Substring(2, 1).Equals("k"))
            {
                d3();
            }
            else if (k.Substring(0, 3).Equals("a"))
            {
                d1(k);
            }
            else
            {
                d0(k);
            }
        }
        public static void d3()
        {
            Console.Write("String kabul edildi");
            Console.Read();

        }

        private static string otomat(string m)
        {
            int d0 = 0;
            int d1 = 0;
            int d2 = 0;
            int d3 = 0;
            int d4 = 0;
            int d5 = 0;
            if (m.Substring(0,1).Equals("ş"))
            {
                d0 = 1;
                d1 = 1;
            }
            else
            {
                d0 = 0;
                d1 = 0;
            }
            if (m.Substring(1, 1).Equals("o"))
            {
                d2 = 1;
            }
            else
            {
                d0 = 0;
                d1 = 0;
                d2 = 0;

            }
            if (m.Substring(2, 1).Equals("f"))
            {
                d3 = 1;
            }
            else
            {
                d0 = 0;
                d1 = 0;
            }
            if (m.Substring(3, 1).Equals("ö"))
            {
                d4 = 1;
            }
            else
            {
                d0 = 0;
                d1 = 0;
                d2 = 0;
                d4 = 0;
            }
            if (m.Substring(4, 1).Equals("r"))
            {
                d5 = 1;
            }
            else
            {
                d0 = 0;
                d1 = 0;
                d2 = 0;
                d4 = 0;
            }
            string kbul = "sitring kabul edilmedi";
            if (d0 == 1 && d1 == 1 && d2 == 1 && d3 == 1 && d4 == 1 && d5 == 1)
            {
                kbul = "Sitring kabul edildi 11";
            }
            return kbul;
        }
    }
}
