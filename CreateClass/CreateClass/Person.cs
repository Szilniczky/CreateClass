using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        String name = "David";
        int birthDate = 1993;
        enum Genders { Male, female };

        public override string ToString()
        {
            return name + " , " + birthDate + " , " + Genders.Male;
        }
    }
}
