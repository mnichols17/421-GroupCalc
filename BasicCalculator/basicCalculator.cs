using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOperations;
using Addition;

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

        public dynamic Add(dynamic a, dynamic b)
        {
            Result = Addition.Add(a, b);
            return Result;
        }
    }


}
