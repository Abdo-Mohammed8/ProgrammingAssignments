using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_oop_2
{
    public class Point3D : IComparable<Point3D>, ICloneable
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public Point3D() : this(0, 0, 0) { }

        public Point3D(int x) : this(x, 0, 0) { }

        public Point3D(int x, int y) : this(x, y, 0) { }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return "Point Coordinates: (" + X + ", " + Y + ", " + Z + ")";
        }

        public int CompareTo(Point3D other)
        {
            int result = this.X.CompareTo(other.X);
            if (result == 0)
            {
                result = this.Y.CompareTo(other.Y);
            }
            return result;
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        public override bool Equals(object obj)
        {
            if (obj is Point3D p)
            {
                return X == p.X && Y == p.Y && Z == p.Z;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        public static bool operator ==(Point3D a, Point3D b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Point3D a, Point3D b)
        {
            return !a.Equals(b);
        }
    }
}
