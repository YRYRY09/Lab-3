using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_3
{
    class Leader : Operator
    {
        public int Experience { get; set; }
        public string Base { get; set; }
        public Leader() { }
        public Leader(string Name, string CarName, string Rank, int Experience, string MainLocation) : base(Name, CarName, Rank)
        {
            this.Experience = Experience;
            this.Base = MainLocation;
        }
        public override void Information()
        {
            Console.WriteLine($"\n{this.Rank} Car initials '{this.CarName}' {this.Name}");
            Console.WriteLine($"Experience: {this.Experience}\nMain base: {this.Base}");
            Debug.WriteLine($"SQLeader: name {this.Name}\ncar initials '{this.CarName}'\nrank '{this.Rank}'\n" +
                $"Experience: {this.Experience}\nMain base: {this.Base}\n");
        }

    }
}