using System;
using System.IO;

namespace ToDoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ToDos = new List<string>();

            string message = "What would you like to do? (Load/Add/Delete/Display/Clear/Quit)";
            Console.WriteLine(message);
            string decision = Console.ReadLine();

            while (decision != "Quit")
            {
                switch (decision)
                {
                    case "Add":
                        {
                            string ToList = Console.ReadLine();
                            ToDos.Add(ToList);
                            Console.WriteLine($"{ToList} added to the list. \n{message}");
                            decision = Console.ReadLine();
                        }
                        break;

                    case "Display":
                        {
                            if (ToDos.Count > 0)
                            {
                                Console.WriteLine("Currently on the list:");

                                foreach (string str in ToDos)
                                    Console.WriteLine(str);
                            }
                            else
                                Console.WriteLine("List is empty.");
                            
                            Console.WriteLine(message);
                            decision = Console.ReadLine();
                        }
                        break;

                    case "Delete":
                        {
                            string fromList = Console.ReadLine();
                            bool removed = ToDos.Remove(fromList);

                            if (removed)
                                ToDos.Remove(fromList);
                            else
                                Console.WriteLine($"{fromList} was not found on the list.");

                            Console.WriteLine($"{fromList} removed from the list. \n{message}");
                            decision = Console.ReadLine();
                        }
                        break;

                    case "Save":
                        {
                            State.Save(ToDos);

                            Console.WriteLine($"List succesfully saved! {message}");
                            decision = Console.ReadLine();
                        }
                        break;

                    case "Load":
                        {
                            ToDos = State.Load();

                            Console.WriteLine($"List succesfully loaded! {message}");
                            decision = Console.ReadLine();
                        }
                        break;

                    case "Clear":
                        {
                            ToDos.Clear();

                            Console.WriteLine($"List cleared. {message}");
                            decision = Console.ReadLine();
                        }
                        break;

                    default:
                        {
                            Console.WriteLine($"Unknown command. \n{message}");
                            decision = Console.ReadLine();
                        }
                        break;               
                }             
            }          
        }
    }
}