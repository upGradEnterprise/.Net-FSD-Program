using System;
using System.Collections.Generic;
using System.IO;

namespace FileIO_GenericList_Example
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }

        public override string ToString()
        {
        //    return string.Format("{0},{1},{2}", EmployeeId, Name, Job);
            return $"{EmployeeId},{Name},{Job}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        { 

            List<Employee> empList = new List<Employee>() {

                new Employee() { EmployeeId = 1026, Name = "Smith-1", Job = "Lead-1" },
                new Employee() { EmployeeId = 1027, Name = "Smith-2", Job = "Lead-2" },
                new Employee() { EmployeeId = 1028, Name = "Smith-3", Job = "Lead-3" },
                new Employee() { EmployeeId = 1029, Name = "Smith-4", Job = "Lead-4" }
            };
 

            string fileName = @"EmpInfo.txt";

            StreamWriter streamWriter = new StreamWriter(fileName, true);
             Console.WriteLine("Content generated at : " + DateTime.Now.ToString("t"));

            Console.WriteLine("Data Generated in File");

            foreach (Employee item in empList)
            {
                streamWriter.WriteLine(item);
            }

            streamWriter.Close();
            Console.ReadLine();
        }
    }
}