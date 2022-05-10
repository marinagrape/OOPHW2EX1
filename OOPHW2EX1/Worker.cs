using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Constructor
//1.Make a class Worker, which will have the following private fields
//-name(name), salary(salary).Make sure that these properties are 
//filled in the constructor when the object is created (like this: 
//new Worker(name, age) ). Make also public methods getName, getSalary.

namespace OOPHW2EX1
{
    class Worker
    {
        private string _name;
        private int _salary;
        private int _age;


        public Worker(string name, int age, int salary)
        {
            _name = name;
            _salary = salary;
            _age = age;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void GetName()
        {
            Console.WriteLine(_name);
        }

        public void SetSalary(int salary)
        {
            _salary = salary;
        }

        public void GetSalary()
        {
            Console.WriteLine(_salary);

        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public void GetAge()
        {
            Console.WriteLine(_age);

        }
    }
}
