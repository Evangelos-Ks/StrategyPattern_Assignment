﻿using System;

namespace Assignment3.Entities.PaymentMethods
{
    public abstract class PaymetnMethod
    {
        public abstract string Name { get; }
        public abstract bool Pay(decimal amount);
        public void DisplayTransactionApprouved(bool pay)
        {
            if (pay)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("\tThe transaction was successful.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("\tThe transaction was unsuccessful.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
