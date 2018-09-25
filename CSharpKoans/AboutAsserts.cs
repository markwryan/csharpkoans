using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpKoans.Core;
using NUnit.Framework;



namespace CSharpKoans
{
  
    public class AboutAsserts : KoanContainer
    {


        // We shall contemplate truth by testing reality, via asserts.

        [Koan]
        public void AssertTruth()
        {  
            // This should be true
            //Mark -- Updated argument to true
             Assert.IsTrue(true);
        }

        // Enlightenment may be more easily achieved with appropriate  messages. 
        [Koan]
        public void AssertWithMessage()
        { 
            //Mark -- Changed first argument to true
            Assert.IsTrue(true, "This should be true -- I made it true."); 
        }

        // To understand reality, we must compare our expectations against reality.
        [Koan]
        public void AssertEquality()
        {
            var expected_value = 1 + 1;
            //Mark -- Updated value from 0 to 2
            var actual_value = 2;

            Assert.AreEqual(expected_value, actual_value);
        }

        // Sometimes we will ask you to fill in the values
        [Koan]
        public void FillInValues()
        {
            //Mark -- Fill in value, add int.Parse call.
            const string __ = "2";

            Assert.AreEqual(1 + 1, int.Parse(__));
        }
    }
}
