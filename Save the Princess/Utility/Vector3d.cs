using System;

namespace Save_the_Princess.Utility
{
	/// <summary>
	/// Stores values relating to a vector and functionality
	/// </summary>
	public struct Vector3d
	{
		public static Vector3d Up => new Vector3d(0, 1, 0);
		public static Vector3d Down => new Vector3d(0, -1, 0);
		public static Vector3d Left => new Vector3d(-1, 0, 0);
		public static Vector3d Right => new Vector3d(1, 0, 0);
		public static Vector3d Forward => new Vector3d(0, 0, 1);
		public static Vector3d Back => new Vector3d(0, 0, -1);
		public static Vector3d Zero => new Vector3d(0, 0, 0);
		
		public double X;

		public double Y;

		public double Z;
		
		public Vector3d(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}
		
		public static Vector3d operator +(Vector3d v1, Vector3d v2)
		{
			return new Vector3d(v1.X+v2.X, v1.Y+v2.Y, v1.Z+v2.Z);
		}

		public static Vector3d operator -(Vector3d v1, Vector3d v2)
		{
			return new Vector3d(v1.X-v2.X, v1.Y-v2.Y, v1.Z-v2.Z);
		}
		
		public static Vector3d operator *(Vector3d v1, double scalar)
		{
			return new Vector3d(v1.X*scalar, v1.Y*scalar, v1.Z*scalar);
		}

		public double Magnitude => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));

		public double Dot(Vector3d other) => X * other.X + Y * other.Y + Z * other.Z;

		public Vector3d Normalize()
		{
			var mag = Magnitude;
			return new Vector3d(X/mag, Y/mag, Z/mag);
		}
	}
}