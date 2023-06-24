using System;
using DenominationRoutine.Services;
using System.Collections.Generic;

namespace DenominationRoutine
{
    class Program
    {
        static void Main()
        {
            int[] denominations = { 10, 50, 100 };
            int[] payoutAmounts = { 30, 50, 60, 80, 140, 230, 370, 610, 980 };

            IPayoutCalculator payoutCalculator = new PayoutCalculator();

            foreach (int amount in payoutAmounts)
            {
                Console.WriteLine($"Payout amount: {amount} EUR");
                Console.WriteLine("Possible combinations:");

                List<List<int>> combinations = payoutCalculator.GetPayoutCombinations(amount, denominations);

                foreach (List<int> combination in combinations)
                {
                    Console.WriteLine(string.Join(" + ", combination));
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

