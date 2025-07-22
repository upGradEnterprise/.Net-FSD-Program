using System.Collections.Generic;

namespace ConsoleApp39
{ 
    public class EventRegistration
    {
        private HashSet<string> registeredEmails;

        public EventRegistration()
        {
            // Case-insensitive comparison
            registeredEmails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        }

        public bool Register(string email)
        {
            if (registeredEmails.Add(email))
            {
                Console.WriteLine($"  Registered: {email}");
                return true;
            }
            else
            {
                Console.WriteLine($"  Duplicate: {email} is already registered.");
                return false;
            }
        }

        public void ShowAllRegistrations()
        {
            Console.WriteLine("\n  Registered Emails:");
            foreach (var email in registeredEmails)
            {
                Console.WriteLine($"- {email}");
            }
        }
    }

    public class Program
    {
        static void Main()
        {
            EventRegistration eventReg = new EventRegistration();

            while (true)
            {
                Console.Write("\nEnter email to register (or 'exit'): ");
                string input = Console.ReadLine();
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                eventReg.Register(input);
            }

            eventReg.ShowAllRegistrations();


            Console.ReadLine();
        }
    }

}
