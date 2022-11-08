using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_2
{
    internal class A
    {
        B b01;
        B b02;
        B b03;
        public A()
        {
        }
        public A(B b01, B b02, B b03)
        {
            this.b01 = b01;
            this.b02 = b02;
            this.b03 = b03;
        }
        public A(B b01, B b02) : this(b01, b02, null)
        {
        }
        public void Time()
        {
            if (b03 == null)
            {
                Console.WriteLine($"{b01.country}, {b01.city}: {b01.cityTime}");
                Console.WriteLine($"{b02.country}, {b02.city}: {b02.cityTime}\n");
            }
            else
            {
                Console.WriteLine($"{b01.country}, {b01.city}: {b01.cityTime}");
                Console.WriteLine($"{b02.country}, {b02.city}: {b02.cityTime}");
                Console.WriteLine($"{b03.country}, {b03.city}: {b03.cityTime}\n");
            }
        }
    }
}