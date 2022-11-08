using Lab_3_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_3 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------");

            Operator ChrisParollo = new Operator("Chris", "AB", "A");
            ChrisParollo.Information();

            Rifleman JackDaSilva = new Rifleman("Silva", "Da Silva's", "Tor", 28, "Con");
            JackDaSilva.Information();

            Leader Ozz = new Leader("Boss", "Ezzy", "Squad", 36, "Base");
            Ozz.Information();

            Operatormobil DeSantos = new Operatormobil("Jack", "CPO", "Impossible", "Cool");
            DeSantos.Information();

            Console.WriteLine("------------------------------------------");

            Console.ReadLine();
        }
    }
}