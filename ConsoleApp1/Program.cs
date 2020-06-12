
using Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

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



            var set = employees.Join(departments,
                                       employ => employ.DebId,
                                       depart => depart.Id,
                                       (employ, depart) =>
                                       new { Name = employ.FirstName, Surname = employ.LastName,Age= employ.Age, depart.Country, depart.City }


                );

            /////// 1
            var task1 = set.Where(x => x.Country == "Ukraine" && x.City != "Donetsk");
            foreach (var item in task1)
            {
                Console.WriteLine($"{item.Name}  {item.Surname} ");
            }
            Console.WriteLine("------------------------------------------------------------------------------------");
            /////////



            //2
            var task2 = departments.Select(x=>x.Country).Distinct();
            foreach (var item in task2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------------------------------");

            //


            //3
            var task3 = employees.Where(x => x.Age > 25).Take(3);
            foreach (var item in task3)
            {
                Console.WriteLine($"{item.FirstName}  {item.LastName} {item.Age}");
            }
            Console.WriteLine("------------------------------------------------------------------------------------");


            var task4 = set.Where(x => x.City=="Kyiv" && x.Age > 23);
            foreach (var item in task4)
            {
                Console.WriteLine($"{item.Name} {item.Surname}");
            }
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
