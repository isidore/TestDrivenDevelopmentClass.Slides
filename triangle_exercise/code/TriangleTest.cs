using ApprovalTests.Reporters;
using ApprovalUtilities.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApprovalTests.Net.StarterProject.Triangle
{
    [TestClass]
    [UseReporter(typeof(DiffReporter))]
    public class TriangleTest
    {
        [TestMethod]
        public void Test3Points()
        {

            // Draw a triangle with connecting [1,1 and 4,10 and 10,2] 
            // verify that it has 3 points
            var triangle = new Triangle(1, 1, 4, 10, 10, 2);
            Assert.AreEqual("[{X=1,Y=1}, {X=4,Y=10}, {X=10,Y=2}]", triangle.Points.ToReadableString());
        }

        [TestMethod]
        public void Test3Sides()
        {

            // Draw a triangle with connecting [1,1 and 4,10 and 10,2] 
            // verify that it has 3 sides
            var triangle = new Triangle(1, 1, 4, 10, 10, 2);
            Assert.AreEqual("[Side [1,1]-[4,10], Side [4,10]-[10,2], Side [10,2]-[1,1]]", triangle.Sides.ToReadableString());
            Approvals.VerifyAll( triangle.Sides,"Sides");
        } [TestMethod]
        public void TestPerimeter()
        {

            // Draw a triangle with connecting [1,1 and 4,10 and 10,2] 
            // verify that it has 3 sides
            var triangle = new Triangle(0,0,4,3,4,0);
            Assert.AreEqual(12, triangle.Perimeter);
        }
    }
}