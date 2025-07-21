using System.Collections.Generic;
 

namespace ConsoleApp39
{    
    class Program
    { 
            static void Main(string[] args)
            {

                Stack<string> undoStack = new Stack<string>();

                // Simulate user actions
                undoStack.Push("Typed 'Hello'");
                undoStack.Push("Bolded Text");
                undoStack.Push("Inserted Image");

                Console.WriteLine("Undo History:");
                foreach (var action in undoStack)
                {
                    Console.WriteLine(action);
                }

                // Perform undo
                Console.WriteLine("\nUndo Actions:");
                while (undoStack.Count > 0)
                {
                    string lastAction = undoStack.Pop();
                    Console.WriteLine($"Undo: {lastAction}");
                }

            Console.ReadLine();
            }
        }    
}
