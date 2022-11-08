using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            B county01 = new B("Ukraine", "Kyiv", DateTime.Now);
            B country02 = new B("England", "Liverpool", DateTime.UtcNow);
            B country03 = new B("USA", "Boston", DateTime.UtcNow.AddHours(-3));
            B country04 = new B("Japan", "Hiroshima", DateTime.UtcNow.AddHours(9));
            B country05 = new B("Australia", "Canberra", DateTime.UtcNow.AddHours(10));

            A country123 = new A(county01, country02, country03);
            country123.Time();
            A country45 = new A(country04, country05);
            country45.Time();

            Console.WriteLine("___________________________________");

            Console.WriteLine("\n*OnlyTime:");
            country03.OnlyTime();
            B03 onlytime = new B03(country03.country, country03.city, country03.cityTime);
            onlytime.OnlyTime();

            Console.WriteLine("___________________________________");

            Console.WriteLine("\n*LongDate:");
            county01.LongDate();
            B01 wholedate = new B01(county01.country, county01.city, county01.cityTime);
            wholedate.LongDate();

            Console.WriteLine("___________________________________");

            Console.WriteLine("\n*ShortDate:");
            country02.ShortDate();
            B02 sdate = new B02(country02.country, country02.city, country02.cityTime);
            sdate.ShortDate();

            Console.WriteLine("___________________________________");
            Console.ReadLine();
        }
    }
}