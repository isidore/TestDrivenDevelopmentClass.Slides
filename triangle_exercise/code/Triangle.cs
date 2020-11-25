using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ApprovalTests.Net.StarterProject.Triangle
{
    public class Triangle
    {
        private Point point1;
        private Point point2;
        private Point point3;

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        { 
            point1 = new Point(x1, y1);
            point2 = new Point(x2, y2);
            point3 = new Point(x3, y3);
        }

        public List<Point> Points
        {
            get
            {
                return new List<Point>
                {
                    point1, point2, point3
                };
            }
        }

        public List<Side> Sides
        {
            get
            {
                return new List<Side>
                {
                    new Side(point1, point2),
                    new Side(point2, point3),
                    new Side(point3, point1)
                };
            }
        }

        public Double Perimeter  {
            get
            {
                return Sides.Sum(s => s.Distance);
            }
        }
    }
}