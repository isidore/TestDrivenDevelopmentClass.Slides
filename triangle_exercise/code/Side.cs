using System;
using System.Collections.Generic;
using System.Drawing;
using ApprovalTests.Reporters;

namespace ApprovalTests.Net.StarterProject.Triangle
{
    public class Side
    {
        public override string ToString()
        {
            return $"Side [{StartX},{StartY}]-[{EndX},{EndY}]";
        }

        public int StartX { get; private set; }
        public int StartY { get; private set; }
        public int EndX { get; private set; }
        public int EndY { get; private set; }

        public Side(int startX, int startY, int endX, int endY)
        {
            StartX = startX;
            StartY = startY;
            EndX = endX;
            EndY = endY;
        }

        public Side(Point point1, Point point2)
        {
            StartX = point1.X;
            StartY = point1.Y;
            EndX = point2.X;
            EndY = point2.Y;
        }

        public double Distance
        {
            get
            {
                long x = EndX - StartX;

                long y = EndY - StartY;

                return Math.Sqrt(x * x + y * y);
            }
        }

        public List<Point> Endpoints
        {
            get
            {
                return new List<Point>{new Point(StartX, StartY), new Point(EndX, EndY)};
            }
        }
    }
}