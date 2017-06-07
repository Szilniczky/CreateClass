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

        public Room(int salary, String profession, int number): base("David", 1993, Genders.Male, 500, "student")
        {
            this.number = number;
        }

        public override string ToString()
        {
            return "Room number is: " + number;
        }
    }
}
