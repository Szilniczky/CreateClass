using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee: Person, ICloneable
    {
        int salary;
        String profession = "student";
        private string v1;
        private DateTime now;
        private int v2;
        private string v3;

        public Employee(string v1, DateTime now, int v2, string v3) : base("David", 1993, Genders.Male)
        {
            this.v1 = v1;
            this.now = now;
            this.v2 = v2;
            this.v3 = v3;
        }

        public Employee(String name, int birthDate, Genders genders, int salary, String profession): base("David", 1993, Genders.Male)
        {
            this.salary = salary;
            this.profession = profession;
        }

        public Room Room { get; set; }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }

        public override string ToString()
        {
            return salary + " , " + profession;
        }

    }
}
