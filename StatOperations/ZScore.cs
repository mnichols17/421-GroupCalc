using System;
using System.Collections.Generic;
using System.Text;
using MathOperations;

namespace StatOperations
{
    class ZScore
    {
        static public void score(int x, int[] nums)
        {
            decimal mean = Mean.findMean(nums);
            decimal SD = StandardDeviation.findSD(nums);

            decimal z = Division.Quotient((x - mean), SD);
        }

        static public void score(decimal x, decimal[] nums)
        {
            decimal mean = Mean.findMean(nums);
            decimal SD = StandardDeviation.findSD(nums);

            decimal z = Division.Quotient((x - mean), SD);
        }
    }
}