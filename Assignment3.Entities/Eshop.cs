using Assignment3.Entities.Enums;
using Assignment3.Entities.PaymentMethods;
using System;

namespace Assignment3.Entities
{
    public class Eshop
    {
        //============================ Fields =========================================================
        protected decimal peymentAmount;
        protected PaymetnMethod payMethod;

        //============================ Methods =========================================================
        #region Ask methods (protected)
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

            Console.ForegroundColor = ConsoleColor.Magenta;
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

            Console.ForegroundColor = ConsoleColor.Magenta;
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

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t=================================================");
            Console.ForegroundColor = ConsoleColor.White;

            return select;
        }

        protected int AskForPaymentMethod()
        {
            int count = 1;
            bool success;
            int select = 0;

            Console.WriteLine();
            Console.WriteLine("\tWith what payment method would you like to pay?");
            Console.WriteLine();
           
            foreach (var paymentMethod in PaymetnMethod.paymentMethodsList)
            {
                Console.WriteLine("\t" + count + "." + " " + paymentMethod.Name);
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
                    if (select < 1 || select > PaymetnMethod.paymentMethodsList.Count)
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

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t=================================================");
            Console.ForegroundColor = ConsoleColor.White;

            return select;
        }
        #endregion

        #region Select methods (protected)
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

        protected PaymetnMethod SelectPaymentMethod(int selectPaymentMethod)
        {
            switch (selectPaymentMethod)
            {
                case 1:
                    return PaymetnMethod.paymentMethodsList[0]; //Credit
                case 2:
                    return PaymetnMethod.paymentMethodsList[1]; // Bank transfer
                case 3:
                    return PaymetnMethod.paymentMethodsList[2]; //Cash
                default:
                    return PaymetnMethod.paymentMethodsList[2]; //Cash
            }
        }
        #endregion

        //============================ Make and dispay Tshirt method ====================================================
        public void MakeAndDisplayTShirt()
        {
            TShirt shirt = new TShirt(SelectFabric(AskForFabric()), SelectColor(AskForColor()), SelectSize(AskForSize()));
            shirt.DisplayTShirt();
            peymentAmount = shirt.TShirtPrice;
        }

        //============================ Choose and dispay PaymentMethod ====================================================
        public void ChooseAndDispayPaymentMethod()
        {
            payMethod = SelectPaymentMethod(AskForPaymentMethod());
        }

        //============================ Pay and Display if the transaction has successed ====================================================
        public void TryToPayAndDisplayTheResult()
        {
            payMethod.DisplayTransactionApprouved(payMethod.Pay(peymentAmount));
        }
    }
}



