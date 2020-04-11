using Assignment3.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Entities
{
    class Eshop
    {
        public int AskForColor()
        {
            int count = 1;
            int select = 0;
            bool success;

            Console.WriteLine();
            Console.WriteLine("\tWhat kind of color would you like?");
            foreach (var color in Color.Cost)
            {
                Console.WriteLine("\t" + count + "." + " " + color.Key);
            }

            do
            {
                Console.WriteLine();
                Console.Write("Insert the appropriate number : ");

                success = true;
                try
                {
                    select = Convert.ToInt32(Console.ReadLine().Trim());
                    success = false;
                    if (select < 1 || select > Color.Cost.Count)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please select an appropriate number");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        success = true;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please select an appropriate number");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    success = true;
                }
            } while (success);

            return select;
        }

        public int AskForFabric()
        {
            int count = 1;
            int select = 0;
            bool success;

            Console.WriteLine();
            Console.WriteLine("\tWhat kind of fabric would you like?");
            foreach (var fabric in Fabric.Cost)
            {
                Console.WriteLine("\t" + count + "." + " " + fabric.Key);
            }

            do
            {
                Console.WriteLine();
                Console.Write("Insert the appropriate number : ");

                success = true;
                try
                {
                    select = Convert.ToInt32(Console.ReadLine().Trim());
                    success = false;
                    if (select < 1 || select > Color.Cost.Count)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please select an appropriate number");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        success = true;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please select an appropriate number");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    success = true;
                }
            } while (success);

            return select;
        }

        public int AskForSize()
        {
            int count = 1;
            int select = 0;
            bool success;

            Console.WriteLine();
            Console.WriteLine("\tWhat kind of size would you like?");
            foreach (var size in Size.Cost)
            {
                Console.WriteLine("\t" + count + "." + " " + size.Key);
            }

            do
            {
                Console.WriteLine();
                Console.Write("Insert the appropriate number : ");

                success = true;
                try
                {
                    select = Convert.ToInt32(Console.ReadLine().Trim());
                    success = false;
                    if (select < 1 || select > Color.Cost.Count)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please select an appropriate number");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        success = true;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please select an appropriate number");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    success = true;
                }
            } while (success);

            return select;
        }
    }
}



