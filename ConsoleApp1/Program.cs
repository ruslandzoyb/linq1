
using Manager;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Department> departments = new List<Department>()
            {
                new Department(){ Id=1,Country="Ukraine",City="Donetsk"},
                new Department(){ Id=2,Country="Ukraine",City="Kyiv"},
                new Department(){ Id=3,Country="France",City="Paris"},
                new Department(){ Id=4,Country="Russia",City="Moscow"}
            };

            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id= 1,FirstName="Tamara",LastName="Ivanova",Age=22,DebId=2 },
                new Employee(){Id= 2,FirstName="Nikita",LastName="Larin",Age=33,DebId=1 },
                new Employee(){Id= 3,FirstName="Alisa",LastName="Ivanova",Age=43,DebId=3 },
                new Employee(){Id= 4,FirstName="Lida",LastName="Marusyk",Age=22,DebId=2 },
                new Employee(){Id= 5,FirstName="Lida",LastName="Voron",Age=36,DebId=4 },
                new Employee(){Id= 6,FirstName="Ivan",LastName="Kalyta",Age=22,DebId=2 },
                new Employee(){Id= 7,FirstName="Nikita",LastName="Krotov",Age=27,DebId=4 },
            };




            Console.ReadLine();
        }
    }
}
