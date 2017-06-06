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
            Person person = new Person();
            Employee employee = new Employee();
            Room room = new Room();
            Console.WriteLine(person);
            Console.WriteLine(employee);
            Console.WriteLine(room);

        }
    }
}
