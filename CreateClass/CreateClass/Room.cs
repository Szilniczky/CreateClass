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

        public override string ToString()
        {
            return "Room number is: " + number;
        }
    }
}
