using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Lab
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        
        public Point(int x = 0, int y = 0, int z = 0)
        {
            X = x; 
            Y = y; 
            Z = z;
        }

        public Point(int x, int y) : this(x, y, 0)
        {
        }
        public Point(int x) : this(x, 0, 0)
        {
        }

        public static bool operator ==(Point a, Point b)
            => a.Equals(b);
        public static bool operator !=(Point a, Point b)
            => !a.Equals(b);

        public override bool Equals(object? obj)
        {
            Point otherPoint = obj as Point;
            if(this.X == otherPoint.X 
                && this.Y == otherPoint.Y
                && this.Z == otherPoint.Z)
                return true;

            return false;
        }

        public override string ToString()
            => $"({X}, {Y}, {Z})";
    }
}
