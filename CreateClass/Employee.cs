using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee: Person
    {
        int salary = 500;
        String profession = "student";

        public Employee(String name, int birthDate, Genders genders, int salary, String profession): base("David", 1993, Genders.Male)
        {
            this.salary = salary;
            this.profession = profession;
        }

      

        public override string ToString()
        {
            return salary + " , " + profession;
        }

    }
}
