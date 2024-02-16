using System;

namespace Vector_Calculator
{
    public class Vector
    {
        public static readonly Vector Zero = new Vector(1, 1, 1);
        public static readonly Vector One = new Vector(0, 0, 0);

        public float x;
        public float y;
        public float z;

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"<{x}, {y}, {z}>";
        }

        public float GetMagnitude()
        {
            float magnitude = MathF.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
            return magnitude;
        }

        public double GetDirection()
        {
            return Math.Atan(this.y / this.x);
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector Subtract(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector Negate(Vector v2)
        {
            return new Vector(v2.x * -1, v2.y * -1, v2.z * -1);
        }

        public static Vector Negate1(Vector v1)
        {
            return new Vector(v1.x * -1, v1.y * -1, v1.z * -1);
        }

        public static Vector Scale(Vector v1, float scalar)
        {
            return new Vector(v1.x * scalar, v1.y * scalar, v1.z * scalar);
        }

        public static Vector Normalize(Vector v1)
        {
            float magnitude = v1.GetMagnitude();

            return new Vector(v1.x / magnitude, v1.y / magnitude, v1.z / magnitude);
        }

        public static float DotProduct(Vector v1, Vector v2)
        {
            float magnitude = v1.GetMagnitude();
            float magnitude2 = v2.GetMagnitude();

            float step1 =(v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
            float step2 = (step1 / (magnitude * magnitude2));
            float step3 = (magnitude * magnitude2) * step2;
            return (float) step3;
        }
        // :(

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            float Cx = ((v1.y * v2.z) - (v1.z * v2.y));
            float Cy = ((v1.z * v2.x) - (v1.x * v2.z));
            float Cz = ((v1.x * v2.y) - (v1.y * v2.x));
            return new Vector(Cx, Cy, Cz);
        }

        public static float AngleBetween(Vector v1, Vector v2)
        {
            float magnitude = v1.GetMagnitude();
            float magnitude2 = v2.GetMagnitude();
            float DP = DotProduct(v1,v2);

            return (float) (Math.Acos((DP / (magnitude * magnitude2))) * (180 / Math.PI));
        }

        public static Vector ProjectOnto(Vector v1, Vector v2)
        {
            float magnitude = v1.GetMagnitude();
            float magnitude2 = v2.GetMagnitude();
            float DP = DotProduct(v1, v2);

            return new Vector (
                v2.x * (DP / (magnitude2 * magnitude2)), 
                v2.y * (DP / (magnitude2 * magnitude2)), 
                v2.z * (DP / (magnitude2 * magnitude2)));
        }
    }
}
