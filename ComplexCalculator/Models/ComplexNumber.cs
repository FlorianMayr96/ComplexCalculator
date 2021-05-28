using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator.Models
{
    /// <summary>
    /// Class representing a complex number
    /// 
    /// Website for testing our complex calculation:
    /// https://www.mathsisfun.com/numbers/complex-number-calculator.html
    /// </summary>
    public class ComplexNumber
    {
        /// <summary>
        /// Possible symbols for the imaginary part
        /// </summary>
        private static readonly string[] mImagSymbols = new string[2] { "j", "i" };

        /// <summary>
        /// Real part
        /// </summary>
        public double Real { get; private set; }

        /// <summary>
        /// Imaginary Part
        /// </summary>
        public double Imag { get; private set; }

        /// <summary>
        /// CTor
        /// </summary>
        /// <param name="real">Real part</param>
        /// <param name="imag">Imaginary part</param>
        public ComplexNumber(double real, double imag = 0)
        {
            Imag = imag;
            Real = real;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            if (Imag < 0)
            {
                return $"{Real:G3} - {Math.Abs(Imag):G3}j";
            }

            return $"{Real:G3} + {Imag:G3}j";
        }

        /// <summary>
        /// Calculates the absolute value of the complex number
        /// </summary>
        /// <returns>The absolute value</returns>
        public double Abs()
        {
            return Math.Sqrt(Real * Real + Imag * Imag);
        }

        /// <summary>
        /// Calculates the argument (phase)
        /// </summary>
        /// <returns>The argument represented as double</returns>
        public double Arg()
        {
            double ret = 0;
            if (Real != 0)
                ret = (180 / Math.PI) * Math.Atan(Imag / Real);
            return (ret);
        }

        /// <summary>
        /// Operator overloading for the Addition
        /// </summary>
        /// <param name="left">The left operand of the operation</param>
        /// <param name="right">The right operand of the operation</param>
        /// <returns>The result of the addition</returns>
        public static ComplexNumber operator +(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber(left.Real + right.Real, left.Imag + right.Imag);
        }

        /// <summary>
        /// Operator overloading for the Substraction
        /// </summary>
        /// <param name="left">The left operand of the operation</param>
        /// <param name="right">The right operand of the operation</param>
        /// <returns>The result of the substration</returns>
        public static ComplexNumber operator -(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber(left.Real - right.Real, left.Imag - right.Imag);
        }

        /// <summary>
        /// Operator overloading for the Multiplication
        /// </summary>
        /// <param name="left">The left operand of the operation</param>
        /// <param name="right">The right operand of the operation</param>
        /// <returns>The result of the multiplication</returns>
        public static ComplexNumber operator *(ComplexNumber left, ComplexNumber right)
        {
            // https://www.mathsisfun.com/algebra/complex-number-multiply.html
            // (a+bi)(c+di) = (ac−bd) + (ad+bc)i

            return new ComplexNumber(
                left.Real * right.Real - left.Imag * right.Imag,
                left.Real * right.Imag + left.Imag * right.Real);
        }

        /// <summary>
        /// Operator overloading for the Division
        /// </summary>
        /// <param name="left">The left operand of the operation</param>
        /// <param name="right">The right operand of the operation</param>
        /// <returns>The result of the division</returns>
        public static ComplexNumber operator /(ComplexNumber left, ComplexNumber right)
        {
            if ((right.Real == 0) && (right.Imag == 0))
            {
                throw new DivideByZeroException("There is a division by zero");
            }

            // https://www.mathwarehouse.com/algebra/complex-number/divide/how-to-divide-complex-numbers.php
            double newReal =
                (left.Real * right.Real + left.Imag * right.Imag) /
                (right.Real * right.Real + right.Imag * right.Imag);

            double newImag =
                (right.Real * left.Imag - left.Real * right.Imag) /
                (right.Real * right.Real + right.Imag * right.Imag);

            return new ComplexNumber(newReal, newImag);
        }

        /// <summary>
        /// Parse a string into a complex number
        /// </summary>
        /// <param name="str">The string that should be parsed</param>
        /// <returns>A complex number</returns>
        /// <exception cref="FormatException">Is thrown if any invalid format occured during parsing.</exception>
        /// <exception cref="OverflowException">Is thrown when any overflow occured</exception>
        /// <exception cref="ArgumentNullException">Is thrown when any argument is null</exception>
        public static ComplexNumber Parse(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException("The passed string is null");
            }

            // remove all whitespaces, so it is possible to parse the string
            string number = str.Replace(" ", "");

            // remove optional '+' operator
            number = number.Trim('+');

            // check if we have only one imaginary symbol
            int numberOfImaginarySymbols = str.Split(mImagSymbols, StringSplitOptions.None).Count() - 1;
            if (numberOfImaginarySymbols != 1)
            {
                throw new FormatException("Invalid format: string contains no or more than one imaginary symbols.");
            }

            // check if we have a positive or negative imaginary part
            string[] numberSplit = number.Split('+');
            if (numberSplit.Count() == 2)
            {
                double real = double.Parse(numberSplit[0]);
                double imag = double.Parse(RemoveImagSymbols(numberSplit[1]));
                return new ComplexNumber(real, imag);
            }

            numberSplit = number.Split('-');
            if (numberSplit.Count() == 2)
            {
                double real = double.Parse(numberSplit[0]);
                double imag = double.Parse(RemoveImagSymbols(numberSplit[1])) * (-1);
                return new ComplexNumber(real, imag);
            }

            throw new FormatException("Invalid input format");
        }

        /// <summary>
        /// Removes all possible imaginary symbols
        /// </summary>
        /// <param name="str">The string, where all imaginary symbols should re removed</param>
        /// <returns>A string that contains no imaginary symbols</returns>
        private static string RemoveImagSymbols(string str)
        {
            foreach (var imagSymbol in mImagSymbols)
            {
                str = str.Replace(imagSymbol, "");
            }

            return str;
        }
    }
}
