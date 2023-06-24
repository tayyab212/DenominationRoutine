using System;
using System.Collections.Generic;
using System.Text;

namespace DenominationRoutine.Services
{
    public class PayoutCalculator : IPayoutCalculator
    {
        public List<List<int>> GetPayoutCombinations(int amount, int[] denominations)
        {
            List<List<int>> combinations = new List<List<int>>();
            List<int> currentCombination = new List<int>();

            CalculateCombinations(amount, denominations, combinations, currentCombination, 0);

            return combinations;
        }

        private void CalculateCombinations(int amount, int[] denominations, List<List<int>> combinations, List<int> currentCombination, int startIndex)
        {
            if (amount == 0)
            {
                combinations.Add(new List<int>(currentCombination));
                return;
            }

            for (int i = startIndex; i < denominations.Length; i++)
            {
                int denomination = denominations[i];

                if (amount >= denomination)
                {
                    currentCombination.Add(denomination);
                    CalculateCombinations(amount - denomination, denominations, combinations, currentCombination, i);
                    currentCombination.RemoveAt(currentCombination.Count - 1);
                }
            }
        }
    }
}
