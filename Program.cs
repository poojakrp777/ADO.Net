using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.net
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Employee employee = new Employee();
            while(true)
            {
                Console.WriteLine("1.create database\n2.create table\n3.Insert record\n4.Delete record\n5.Retrieve data\n6.Update Record\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        employee.CreateDatabase();
                        break;
                    case 2:
                        employee.CreateTable();
                        break;
                    case 3:
                        Console.WriteLine("enter Firstname");
                        string name=Console.ReadLine();
                        Console.WriteLine("enter salary");
                        int salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter age");
                        int age = Convert.ToInt32(Console.ReadLine());

                        employee.InsertRecord(name, salary, age);
                        break;
                    case 4:
                        Console.WriteLine("Enter the Name First");
                        string name1 = Console.ReadLine();
                        employee.Delete(name1);
                        break;
                    case 5:
                        employee.Retrievedata();
                        break;
                    case 6:
                        Console.WriteLine("Enter the First Name");
                        string name2 = Console.ReadLine();
                        Console.WriteLine("Enter the Salary");
                        string salary2 = Console.ReadLine();

                        employee.Updatedata(name2, salary2);
                        break;

                    default:
                        Console.WriteLine("Enter the Number Within Range");
                        break;



                }
            }
        }
    }
}
