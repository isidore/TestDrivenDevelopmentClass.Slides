using System;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using ApprovalUtilities.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApprovalTests.Net.StarterProject.Triangle
{
    [TestClass]
    [UseReporter(typeof(DiffReporter))]
    public class SideTest
    {
        [TestMethod]
        public void TestLotsOfDistances()
        {
            var numbers = new int[] {0,1,-1,Int32.MaxValue, Int32.MinValue, };
            CombinationApprovals.VerifyAllCombinations((x1,y1,x2,y2) => new Side(x1,y1,x2,y2).Distance,
                numbers,numbers,numbers,numbers );
        }

        [TestMethod]
        public void TestMethodHorizontal()
        {
            var side = new Side(0,0,5,0);
            Assert.AreEqual(5, side.Distance);
        }

        [TestMethod]
        public void TestMethodVertical()
        {
            var side = new Side(2, 0, 2, 5);
            Assert.AreEqual(5, side.Distance);
        }

        [TestMethod]
        public void TestMethodDiagonal()
        {
            var side = new Side(0, 0, 3, 4);
            Assert.AreEqual(5, side.Distance);
        }

        [TestMethod]
        public void TestSideHasEnds()
        {
            // create a side with [1,3], to [2,7] ending at [2,7]
            // verify that the side has starts and end points
            var side = new Side(1, 3, 2, 7);
            Assert.AreEqual("[{X=1,Y=3}, {X=2,Y=7}]", side.Endpoints.ToReadableString());
        }
    }
}