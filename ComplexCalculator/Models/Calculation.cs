using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator.Models
{
    public class Calculation
    {
        public ComplexNumber FirstNumber { get; }
        public ComplexNumber SecondNumber { get; }
        public ComplexNumber Result { get; }
        public string Operation { get; }

        public Calculation(ComplexNumber firstNumber, ComplexNumber secondNumber, ComplexNumber result, string operation)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Result = result;
            Operation = operation;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{FirstNumber} {Operation} {SecondNumber} = {Result}";
        }
    }
}
