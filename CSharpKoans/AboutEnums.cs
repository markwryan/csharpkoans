using CSharpKoans.Core;
using NUnit.Framework;
using System;

namespace CSharpKoans
{
    public class AboutEnums : KoanContainer
    {
        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        [Koan]
        public void UnderstandTheDefaultValueOfEnumConstants()
        {
            var dir = new Direction();
            //Mark -- Updated to correct default values, casted enum to int
            Assert.AreEqual(0, (int) dir);

            Assert.AreEqual(2, (int) Direction.Left);
        }

        public enum DaysOfTheWeek
        {
            Sunday = 1,
            Monday,
            Tuesday,
            Wednesday = 10,
            Thursday,
            Friday = 15,
            Saturday
        }

        [Koan]
        public void UnderstandHowEnumVariablesAreAssigned()
        {
            var tue = DaysOfTheWeek.Tuesday;
            var thur = DaysOfTheWeek.Thursday;
            var sat = DaysOfTheWeek.Saturday;
            //Mark -- added casts cause nUnit. Updated expected values.
            Assert.AreEqual(3, (int) tue);
            Assert.AreEqual(11, (int) thur);
            Assert.AreEqual(16, (int) sat);

        }

        [Koan]
        public void EnumsCanTakeUndefinedValues()
        {
            var toBeInvalid = Direction.Right;

            // reassign toBeInvalid.
            // A cast may be needed
            //Mark -- Cast and assign 42, add cast to nUnit to assert below
            toBeInvalid = (Direction)42;

            Assert.AreEqual(42, (int)toBeInvalid);
        }
        
        [Flags]
        public enum Styles
        {
            Plain = 0,
            Rounded = 1,
            Squared = 2,
            Raised = 4,
            Sunken = 8
        }

        [Koan]
        public void BitFlagsCanBeCombined()
        {
            var composite = Styles.Rounded | Styles.Raised;

            Assert.AreEqual(Styles.Rounded | Styles.Raised, composite);
        }

        [Koan]
        public void DefaultEnumValuesIgnoreAssignedValues()
        {
            var day = default(DaysOfTheWeek);

            Assert.AreEqual((DaysOfTheWeek) 0, day);
        }
    }
}