using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("David", 1993, Genders.Male);
            Employee employee = new Employee("David", 1993, Genders.Male, 500, "student");
            Room room = new Room(500, "student", 1);
            Console.WriteLine(person.ToString());
            Console.WriteLine(employee.ToString());
            Console.WriteLine(room.ToString());
            Console.ReadLine();
        }
    }
}
