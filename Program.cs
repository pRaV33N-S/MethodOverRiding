using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRiding
{
    public class Employee
    {
        int id;
        string name;
        double sal;
        public void Register()
        {
            Console.WriteLine("Enter Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            sal = double.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine($"ID : {id}\nName : {name}\nSalary : {sal}");
        }
    }
    public class Developer : Employee
    {
        string domain;
        string projects;
        public void Register()
        {
            //base.Register();
            Console.WriteLine("Enter Domain");
            domain = Console.ReadLine();
            Console.WriteLine("Enter Project");
            projects = Console.ReadLine();
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine($"Domain : {domain}\nProjects : {projects}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();
            //emp.Register();
            //emp.Display();
            Developer dev = new Developer();
            dev.Register();
            dev.Display();
        }
    }
}
