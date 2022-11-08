using Lab_3_3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_3
{
    class Operatormobil : Operator
    {
        public string CarType { get; set; }
        public Operatormobil() { }
        public Operatormobil(string Name, string CarName, string Rank, string cartype) : base(Name, CarName, Rank)
        {
            this.CarType = cartype;
        }
        public override void Information()
        {
            Console.WriteLine($"\nName {this.Name}\nCar initials '{this.CarName}'\nRank '{this.Rank}'\n" +
                $"Car type: {this.CarType}\n");
            Debug.WriteLine($"Operatormobil: name {this.Name}\ncar initials '{this.CarName}'\nrank '{this.Rank}'\n" +
                $"Car type: {this.CarType}\n");
        }
    }
}