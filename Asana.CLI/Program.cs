﻿using Asana.Library.Models;
using System;


namespace Asana
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var toDos = new List<ToDo>();
            var choiceInt = 0;
            do
            {
                Console.WriteLine("Choose a menu option: ");
                Console.WriteLine("1. Create a ToDo");
                Console.WriteLine("2. Exit");

                var choice = Console.ReadLine() ?? "2";

                if (int.TryParse(choice, out choiceInt))
                {

                    switch (choiceInt)
                    {
                        case 1:
                            Console.Write("name:");
                            var name = Console.ReadLine();
                            Console.Write("Description:");
                            var description = Console.ReadLine();

                            toDos.Add(new ToDo { Name = name, Description = description });
                            break;
                        case 2:
                            break;
                        default:
                            Console.WriteLine("Error: Unknown menu selection");
                            break;
                    }
                }
                else{ Console.WriteLine($"Error: {choice} is not a valid menu selection!"); }
                    if (toDos.Any()){
                    Console.WriteLine(toDos.Last());
                }
                    
            } while (choiceInt != 2);

        }
    }
}