using System;
using System.Text.RegularExpressions;

namespace martin_linkedlist
{
    class Program
    {
        private static ConsoleKeyInfo storeKey;
        private static LinkedList ll = new LinkedList();

        public static void Main(string[] args)
        {
            do
            {
                OptionsMenu();
                storeKey = KeyInput();
                Console.Clear();
                if(CheckKey(storeKey))
                {
                    DirectUser(storeKey, ll);
                }

            } while (storeKey.Key != ConsoleKey.D5);
        }

        private static void OptionsMenu()
        {
                Console.WriteLine("Choose from the following options:");
                Console.WriteLine("1. Add an item:");
                Console.WriteLine("2. Remove an item:");
                Console.WriteLine("3. Search for item:");
                Console.WriteLine("4. Print list:");
                Console.WriteLine("5. Exit:");
        }

        private static ConsoleKeyInfo KeyInput()
        {
            ConsoleKeyInfo keyInput = Console.ReadKey();
            return keyInput;
        }

        private static bool CheckKey(ConsoleKeyInfo testInput)
        {
            if (!Regex.Match(testInput.Key.ToString(), ".*[1-5].*").Success)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void DirectUser(ConsoleKeyInfo directingKey, LinkedList ll)
        {
            string userInput;

            switch (directingKey.Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.Write("Please enter an item: ");
                        userInput = Console.ReadLine().ToLower();
                        ll.Add(userInput);
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        Console.Write("Please remove an item: ");
                        userInput = Console.ReadLine().ToLower();
                        if(!ll.Remove(userInput))
                        {
                            Console.WriteLine("No data matched " + userInput + ".");
                        }
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        Console.Write("Please search an item: ");
                        userInput = Console.ReadLine().ToLower();
                        if(ll.Contains(userInput))
                        {
                            Console.WriteLine("");
                            Console.WriteLine(userInput + " was found.");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Item " + userInput + " was not found.");
                            Console.WriteLine("");
                        }
                        break;
                    }
                case ConsoleKey.D4:
                    {
                        ll.PrintAllNodes();
                        break;
                    }
                case ConsoleKey.D5:
                    {
                        break;
                    }
            }
        }
    }
}
