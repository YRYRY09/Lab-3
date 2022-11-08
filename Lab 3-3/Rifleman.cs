using Lab_3_3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_3
{
    class Rifleman : Operator
    {
        public int Guns { get; set; }
        public string GunType { get; set; }
        public Rifleman() { }
        public Rifleman(string Name, string CarName, string Rank, int cannons, string cannon_type) : base(Name, CarName, Rank)
        {
            this.Guns = cannons;
            this.GunType = cannon_type;
        }
        public override void Information()
        {
            Console.WriteLine($"name {this.Name}\ncar initials '{this.CarName}'\nrank '{this.Rank}'\n" +
                $"Guns in tech workshop: {this.Guns}\nGun type: {this.GunType}\n");
            Debug.WriteLine($"Rifleman: name {this.Name}\ncar '{this.CarName}'\nrank '{this.Rank}'\n" +
                $"Guns in tech workshop: {this.Guns}\nGun type: {this.GunType}\n");
        }
    }
}