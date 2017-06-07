using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public enum Genders { Male, female };

    class Person
    {
        String name = "David";
        int birthDate = 1993;
        private Genders genders;

        public Person(String name, int birthDate, Genders genders)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.genders = genders;
        }

        public override string ToString()
        {
            return name + " , " + birthDate + " , " + Genders.Male;
        }
    }
}
