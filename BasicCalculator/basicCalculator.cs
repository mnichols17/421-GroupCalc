using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOperations;
using Addition;
using Subtraction;
using Division;

namespace BasicCalculator
{
    public class BasicCalculator
    {
        private dynamic _result;

        public dynamic Result
        {
            get => _result;
            set => _result = value;
        }

        Sum Addition = new Sum();
        Difference Subtraction = new Difference();
        Quotient Division = new Quotient();

        public dynamic Add(dynamic a, dynamic b)
        {
            Result = Addition.Add(a, b);
            return Result;
        }

        public dynamic Add(dynamic arrayList)
        {
            Result = Addition.Add(arrayList);
            return Result;
        }

        public dynamic Subtract(dynamic a, dynamic b)
        {
            Result = Subtraction.Subtract(a, b);
            return Result;
        }

        public dynamic Subtract(dynamic arrayList)
        {
            Result = Subtraction.Subtract(arrayList);
            return Result;
        }

        public dynamic Divide(dynamic dividend, dynamic divisor)
        {
            Result = Division.Divide(dividend, divisor);
            return Result;
        }
        public dynamic Divide(dynamic arrayList)
        {
            Result = Division.Divide(arrayList);
            return Result;
        }
    }


}
