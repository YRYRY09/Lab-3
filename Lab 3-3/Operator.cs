using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_3
{
    internal class Operator
    {
        public string Name { get; set; }
        public string CarName { get; set; }
        public string Rank { get; set; }
        public Operator() { }
        public Operator(string name, string CarName, string Rank)
        {
            this.Name = name;
            this.CarName = CarName;
            this.Rank = Rank;
        }

        public virtual void Information()
        {
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Car initials: {this.CarName}");
            Console.WriteLine($"Rank: {this.Rank}");
            Debug.WriteLine($"Class Operator: Name {this.Name}, car '{this.CarName}', rank '{this.Rank}'\n");
        }
    }
}