using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Room: Employee
    {
        int number = 1;

        public Room(int number): base("David", 1993, Genders.Male, 500, "student")
        {
            this.number = number;
        }

        public int Number { get; internal set; }

        public override string ToString()
        {
            return "Room number is: " + number;
        }
    }
}
