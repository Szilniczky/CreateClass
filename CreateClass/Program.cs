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
            Room room = new Room(1);
            Console.WriteLine(person.ToString());
            Console.WriteLine(employee.ToString());
            Console.WriteLine(room.ToString());
            Console.ReadLine();

            Employee Kovacs = new Employee("Géza", DateTime.Now, 1000, "léhűtő");
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.Number = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }
}
