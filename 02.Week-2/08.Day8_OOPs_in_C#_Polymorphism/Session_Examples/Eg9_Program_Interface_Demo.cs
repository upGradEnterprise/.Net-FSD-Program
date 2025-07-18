 

namespace ConsoleApp39
{
    interface IMathInterface
    {
        int Add(int x, int y);
     
        int Multiply(int x, int y);
    }

    interface IStringInterface
    {
        string Combine(string s1, string s2);

        string ChangeToUpperCase(string s1);
    }

    class TestClass : IMathInterface, IStringInterface
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public string Combine(string s1, string s2)
        {
            return  string.Concat(s1, s2);  
        }

        public string ChangeToUpperCase(string s1)
        {
            return s1.ToUpper();    
        }
    }

 

    class Program
    {
        static void Main(string[] args)
        {
            
            TestClass  testClass = new TestClass();


            Console.WriteLine(testClass.Add(10, 20));
            Console.WriteLine(testClass.Multiply(10, 20));
            Console.WriteLine(testClass.Combine("Hello", " World"));
            Console.WriteLine(testClass.ChangeToUpperCase("Working with interfaces"));


            Console.ReadLine();
        }
    }
}
