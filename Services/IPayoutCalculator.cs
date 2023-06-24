using System;
using System.Collections.Generic;
using System.Text;

namespace DenominationRoutine.Services
{
   public interface IPayoutCalculator
    {
        List<List<int>> GetPayoutCombinations(int amount, int[] denominations);
    }
}
