using Assignment3.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Entities
{
    public class Eshop
    {
        //============================ Ask methods ====================================================
        protected int AskForColor()
        {
            int count = 1;
            int select = 0;
            bool success;

            Console.WriteLine();
            Console.WriteLine("\tWhat kind of color would you like?");
            Console.WriteLine();
            foreach (var color in Color.Cost)
            {
                Console.WriteLine("\t" + count + "." + " " + color.Key);
                count++;
            }

            do
            {
                Console.WriteLine();
                Console.Write("\tInsert the appropriate number : ");

                success = true;
                try
                {
                    select = Convert.ToInt32(Console.ReadLine().Trim());
                    success = false;
                    if (select < 1 || select > Color.Cost.Count)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tPlease select an appropriate number");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        success = true;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tPlease select an appropriate number");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    success = true;
                }
            } while (success);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t=================================================");
            Console.ForegroundColor = ConsoleColor.White;

            return select;
        }

        protected int AskForFabric()
        {
            int count = 1;
            int select = 0;
            bool success;

            Console.WriteLine();
            Console.WriteLine("\tWhat kind of fabric would you like?");
            Console.WriteLine();

            foreach (var fabric in Fabric.Cost)
            {
                Console.WriteLine("\t" + count + "." + " " + fabric.Key);
                count++;
            }

            do
            {
                Console.WriteLine();
                Console.Write("\tInsert the appropriate number : ");

                success = true;
                try
                {
                    select = Convert.ToInt32(Console.ReadLine().Trim());
                    success = false;
                    if (select < 1 || select > Color.Cost.Count)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tPlease select an appropriate number");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        success = true;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tPlease select an appropriate number");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    success = true;
                }
            } while (success);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t=================================================");
            Console.ForegroundColor = ConsoleColor.White;

            return select;
        }

        protected int AskForSize()
        {
            int count = 1;
            int select = 0;
            bool success;

            Console.WriteLine();
            Console.WriteLine("\tWhat kind of size would you like?");
            Console.WriteLine();

            foreach (var size in Size.Cost)
            {
                Console.WriteLine("\t" + count + "." + " " + size.Key);
                count++;
            }

            do
            {
                Console.WriteLine();
                Console.Write("\tInsert the appropriate number : ");

                success = true;
                try
                {
                    select = Convert.ToInt32(Console.ReadLine().Trim());
                    success = false;
                    if (select < 1 || select > Color.Cost.Count)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tPlease select an appropriate number");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        success = true;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tPlease select an appropriate number");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    success = true;
                }
            } while (success);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t=================================================");
            Console.ForegroundColor = ConsoleColor.White;

            return select;
        }

        //============================ Select methods ====================================================

        protected Colors SelectColor(int selectColor)
        {
            switch (selectColor)
            {
                case 1:
                    return Colors.Blue;
                case 2:
                    return Colors.Green;
                case 3:
                    return Colors.Indigo;
                case 4:
                    return Colors.Orange;
                case 5:
                    return Colors.Red;
                case 6:
                    return Colors.Violet;
                default:
                    return Colors.Yellow;
            }
        }

        protected Sizes SelectSize(int selectSize)
        {
            switch (selectSize)
            {
                case 1:
                    return Sizes.XS;
                case 2:
                    return Sizes.S;
                case 3:
                    return Sizes.M;
                case 4:
                    return Sizes.L;
                case 5:
                    return Sizes.XL;
                case 6:
                    return Sizes.XXL;
                default:
                    return Sizes.XXXL;
            }
        }

        protected Fabrics SelectFabric(int selectFabric)
        {
            switch (selectFabric)
            {
                case 1:
                    return Fabrics.Cashmere;
                case 2:
                    return Fabrics.Cotton;
                case 3:
                    return Fabrics.Linel;
                case 4:
                    return Fabrics.Polyester;
                case 5:
                    return Fabrics.Rayon;
                case 6:
                    return Fabrics.Silk;
                default:
                    return Fabrics.Wool;
            }
        }

        //============================ Make and dispay Tshirt method ====================================================
        public void MakeAndDisplayTShirt()
        {
            TShirt shirt = new TShirt(SelectFabric(AskForFabric()), SelectColor(AskForColor()), SelectSize(AskForSize()));
            shirt.DisplayTShirt();
        }
    }
}



