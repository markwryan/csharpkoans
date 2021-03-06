﻿using System;
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
            // Update this assert to pass
             Assert.IsTrue(false);
        }

        // Enlightenment may be more easily achieved with appropriate messages. 
        [Koan]
        public void AssertWithMessage()
        { 
            Assert.IsTrue(false, "This should be true -- Please fix this"); 
        }

        // To understand reality, we must compare our expectations against reality.
        [Koan]
        public void AssertEquality()
        {
            const int expected_value = 1 + 1;
            //Update the actual value to match the expected value
            var actual_value = 0;

            Assert.AreEqual(expected_value, actual_value);
        }

        // Sometimes we will ask you to fill in the values, using the placeholder `[__expected-type__]`.)
        [Koan]
        public void FillInValues()
        {
            Assert.AreEqual(1 + 1, "[__int__]");
        }
    }
}
