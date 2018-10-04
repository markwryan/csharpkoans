using System;
using CSharpKoans.Core;
using NUnit.Framework;

namespace CSharpKoans
{
    public class AboutStructs : KoanContainer
    {
        public struct Point
        {
            public double X;
            public double Y;

            internal double Distance(Point p2)
            {
                return Math.Sqrt(Math.Pow((p2.X - this.X),2) + Math.Pow((p2.Y - this.Y), 2));
            }
        }

        private const double FILL_ME_N = -1;

        [Koan]
        public void UnderstandDefaultValuesForStructcs()
        {
            var pt = new Point();

            Assert.AreEqual(0.0d, pt.X);
            Assert.AreEqual(0.0d, pt.Y);
        }

        [Koan]
        public void UnderstandStructCopySemantics()
        {
            var pt1 = new Point
            {
                X = 3,
                Y = 4
            };

            var pt2 = pt1;

            pt2.X *= 2;
            pt2.Y *= 2;

            Assert.AreEqual(3d, pt1.X);
            Assert.AreEqual(4d, pt1.Y);
            Assert.AreEqual(6d, pt2.X);
            Assert.AreEqual(8d, pt2.Y);
        }

        [Koan]
        public void UndestandStructConversionsToObject()
        {
            var pt1 = new Point
            {
                X = 3,
                Y = 4
            };

            object pt2 = pt1;

            pt1.X = 12;

            Assert.AreEqual(3d, ((Point)pt2).X);
        }

        [Koan]
        public void UnderstandHowToCreateMethodsInStructs()
        {
            var pt1 = new Point
            {
                X = 3,
                Y = 4
            };

            double distance = -1;

            // Uncomment this line and implement the distance property:
            // Hint: The System.Math class has a Sqrt() method that calculates Square roots.
            distance = pt1.Distance(new Point());

            Assert.AreEqual(5, distance);
        }


    }
}