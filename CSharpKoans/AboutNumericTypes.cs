using CSharpKoans.Core;
using NUnit.Framework;

namespace CSharpKoans
{
    public class AboutNumericTypes : KoanContainer
    {
        [Koan]
        public void UnderstandTheDefaultNumericType()
        {
            var i = 42;

            // Update typeof to match the type of i
            Assert.AreEqual(typeof(string), i.GetType());
        }

        [Koan]
        public void LossyConversionsAreExplicit()
        {
            const int initialValue = 5;
            const double implicitlyConverted = initialValue;

            var finalValue = 0;
            // uncomment this line and fix the compiler error:
            // finalValue = implicitlyConverted;

            Assert.AreEqual(initialValue, finalValue);
        }

        [Koan]
        public void IntegerMathPerformsRounding()
        {
            const int numerator = 27;
            const int denominator = 5;

            var expected = "[__int__]";
            int actual = numerator / denominator;
            Assert.AreEqual(expected, actual);
        }

        [Koan]
        public void FloatingPointMathIncludesDecimalFractions()
        {
            double numerator = 27;
            double denominator = 5;

            double expected = default(double);
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
            for (int i = 0; i < 1000000; i++)
            {
                //Update this assignment
                total = total + increment;
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

            Assert.AreEqual("[__int__]", i);
            // You may need to look at the value of j in the debugger to
            // fix this one:
            Assert.AreEqual("[__int__]", j);
        }

        [Koan]
        public void MixingSignedAndUnsignedMathCausesConversions()
        {
            int i = 5;
            uint j = 25;

            var k = i + j;

            // What type is k?
            Assert.AreEqual(typeof(int), k.GetType());

        }
    }
}