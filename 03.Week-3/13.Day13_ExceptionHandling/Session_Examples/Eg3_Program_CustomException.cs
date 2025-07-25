
namespace ConsoleApp39
{
    public class InvalidAgeException : ApplicationException
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter your age: ");
            int age;

            try
            {
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 18 || age > 40)
                {
                    throw new InvalidAgeException("Your age must be between 18 and 40.");
                }
                Console.WriteLine("You are eligible to register your details!");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Exception Message: Please enter a valid number.");
            }


            Console.ReadLine();
        }
    }
}