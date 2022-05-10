using System;

//Constructor
//1.Make a class Worker, which will have the following private fields
//-name(name), salary(salary).Make sure that these properties are 
//filled in the constructor when the object is created (like this: 
//new Worker(name, age) ). Make also public methods getName, getSalary.

//Create an object of this class 'John', age 25, salary 1000.
//Display his age and salary.

namespace OOPHW2EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("John",25, 1000);

            worker1.GetName();
            worker1.GetAge();
            worker1.GetSalary();

        }
    }
}
