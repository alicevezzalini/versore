using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versore
{
    internal class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Vector Parse(string s)
        {
            string[] strings = s.Split(';');
            return new Vector(double.Parse(strings[0]), double.Parse(strings[1]));
        }

        public override string ToString()
        {
            return string.Format("{0};{1}", X, Y);
        }

        public virtual double Modulo()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public static Vector operator +(Vector v)
        {
            return v;
        }

        public static Vector operator -(Vector v)
        {
            return new Vector(-v.X, v.Y);
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y);
        }

        public static Vector operator *(Vector a, double scalar)
        {
            return new Vector(scalar * a.X, scalar * a.Y);
        }

        public static Vector operator *(double scalar, Vector a)
        {
            return new Vector(scalar * a.X, scalar * a.Y);
        }

        public static double operator *(Vector a, Vector b)
        {
            return a.X * b.X + a.Y * b.Y;
        }

        public static double operator /(Vector a, double scalar)
        {
            return a.Modulo() / scalar;
        }

        public static bool operator ==(Vector a, Vector b)
        {
            if (object.ReferenceEquals(a, null))
                return object.ReferenceEquals(b, null);
            else if (object.ReferenceEquals(b, null))
                return false;
            else
                return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(Vector a, Vector b)
        {
            return !(a == b);
        }

        public Vector Versore()
        {
            return new Vector(X/Modulo(), Y/Modulo());
        }
    }
}
