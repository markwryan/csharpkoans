using CSharpKoans.Core;
using NUnit.Framework;
using System;

namespace CSharpKoans
{
    public class AboutNumericTypes : KoanContainer
    {
        [Koan]
        public void UnderstandTheDefaultNumericType()
        {
            var i = 42;

            // What type is i?
            Assert.AreEqual(typeof(int), i.GetType());
        }

        [Koan]
        public void LossyConversionsAreExplicit()
        {
            int initialValue = 5;
            double implicitlyConverted = initialValue;

            int finalValue = default(int);
            // uncomment this line and fix the compiler error:
            //Mark -- implicitly cast to int
            finalValue = (int) implicitlyConverted;

            Assert.AreEqual(initialValue, finalValue);
        }

        [Koan]
        public void IntegerMathPerformsRounding()
        {
            int numerator = 27;
            int denominator = 5;
            //Mark -- Updated expected int to 27/5 rounded down to 5
            int expected = 5;
            int actual = numerator / denominator;
            Assert.AreEqual(expected, actual);
        }

        [Koan]
        public void FloatingPointMathIncludesDecimalFractions()
        {
            double numerator = 27;
            double denominator = 5;
            //Mark -- Updated expected value to non-rounded answer
            double expected = 5.4;
            double actual = numerator / denominator;
            Assert.AreEqual(expected, actual);
        }

        [Koan]
        public void FloatingPointIntroducesRoundingErrors()
        {
            double[] values = new double[1000000];

            double total = 0.000;
            double increment = 0.001; // This is 1/1000

            // rewrite this loop to minimize the accumulating
            // rounding error
            //Mark -- switched increment and storage into array, Round total to 3 decimals before incrementing to avoid precision loss
            for (int i = 0; i < 1000000; i++)
            {
                total = Math.Round(total, 3) + increment;
                values[i] = total;
            }
            var testVal = values[999999];
            Assert.AreEqual(1000.0, testVal);
        }

        [Koan]
        public void IntegralValuesCanBeSignedOrUnsigned()
        {
            int i = 25;
            uint j = 50;

            i -= 100;

            j -= 200;

            // Mark -- Update with expected value.
            Assert.AreEqual(-75, i);
            // You may need to look at the value of j in the debugger to
            // fix this one:
            Assert.AreEqual(4294967146, j);
        }

        [Koan]
        public void MixingSignedAndUnsignedMathCausesConversions()
        {
            int i = 5;
            uint j = 25;

            var k = i + j;

            // What type is k?
            //Mark -- Updated expected type to long
            Assert.AreEqual(typeof(long), k.GetType());

        }
    }
}