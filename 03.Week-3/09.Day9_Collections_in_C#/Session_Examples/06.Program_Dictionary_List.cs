using System.Collections.Generic;
using System.Xml.Linq;

namespace ConsoleApp39
{    
    class Program
    { 
            static void Main(string[] args)
            {
            Dictionary<string, List<int>> studentGrades = new Dictionary<string, List<int>>()
            {
                { "Scott", new List<int>{ 56, 89, 74, 58 } },
                { "Smith", new List<int>{ 56, 89, 74, 58, 96 } },
                { "Sandy", new List<int>{ 56, 89, 74, 58 } }
            };


            studentGrades["Scott"].Add(68);


            foreach (var key in studentGrades.Keys)
            {
                List<int> lst = studentGrades[key];
                string csvStr = string.Join(",", lst);
                Console.WriteLine(csvStr);

                // Console.WriteLine(string.Join(",", studentGrades[key]));
            }


                    


 

            Console.ReadLine();
            }
        }    
}
