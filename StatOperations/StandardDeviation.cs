using System;
using System.Collections.Generic;
using System.Text;
using MathOperations;

namespace StatOperations
{
    public static class StandardDeviation
    {
        static public decimal findSD(int[] nums)
        {
            return Convert.ToDecimal(Math.Round(Root.rootAns(Convert.ToDouble(Variance.findVariance(nums)), 2), 7));
        }

        static public decimal findSD(decimal[] nums)
        {
            return Convert.ToDecimal(Math.Round(Root.rootAns(Convert.ToDouble(Variance.findVariance(nums)), 2), 7));
        }
    }
}