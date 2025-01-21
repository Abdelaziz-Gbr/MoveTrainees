using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveTrainees
{
    internal class Trainee
    {
        public string name;
        public int lab;

        public Trainee(string name) { this.name = name; lab = 0; }
        public override string ToString()
        {
            return name;
        }
    }
}
