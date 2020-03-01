using System;

namespace Game.Infrastructure.Utils
{
	public class Vector3
	{
		public static Vector3 Min(Vector3 vec1, Vector3 vec2)
        {
            return new Vector3(
	                Math.Min(vec1.X, vec2.X),
	                Math.Min(vec1.Y, vec2.Y),
	                Math.Min(vec1.Z, vec2.Z)
                );
        }

        public static Vector3 Max(Vector3 vec1, Vector3 vec2)
        {
            return new Vector3(
	                Math.Max(vec1.X, vec2.X),
	                Math.Max(vec1.Y, vec2.Y),
	                Math.Max(vec1.Z, vec2.Z)
                );
        }
		
		public double X, Y, Z;
		
		public Vector3()
		{
			X = Y = Z = 0;
		}
		
		public Vector3(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}
		
		public void Add(double x, double y, double z)
		{
			X += x;
			Y += y;
			Z += z;
		}
		
		public void Sub(double x, double y, double z)
		{
			X -= x;
			Y -= y;
			Z -= z;
		}
		
		public void Multi(double x, double y, double z)
		{
			X *= x;
			Y *= y;
			Z *= z;
		}
		
		public void Div(double x, double y, double z)
		{
			X /= x;
			Y /= y;
			Z /= z;
		}
		
		public double Distance(Vector3 pos) 
		{
	        return Math.Sqrt(this.DistanceSquared(pos));
	    }
	
	    public double DistanceSquared(Vector3 vec) 
	    {
	        return Math.Pow(X - vec.X, 2) + Math.Pow(Y - vec.Y, 2) + Math.Pow(Z - vec.Z, 2);
	    }		
	
		public Vector3 Floor
		{
			get { return new Vector3(Math.Floor(X), Math.Floor(Y), Math.Floor(Z)); }
		}
		
		public Vector3 Abs
		{
			get { return new Vector3(Math.Abs(X), Math.Abs(Y), Math.Abs(Z)); }
		}
		
		public virtual bool Equals(Vector3 vec)
        {
            return vec.X.Equals(X) && vec.Y.Equals(Y) && vec.Z.Equals(Z);
        }
		
		public float[] Float
		{
			get { return new float[3] { (float) X, (float) Y, (float) Z }; }
		}
		
		public int FloorX
		{
			get { return (int) Math.Floor(X); }
		}
		
		public int FloorY
		{
			get { return (int) Math.Floor(Y); }
		}
		
		public int FloorZ
		{
			get { return (int) Math.Floor(Z); }
		}
		
		public int ChunkX
		{
			get { return FloorX >> 4; }
		}
		
		
		public int ChunkY
		{
			get { return FloorY >> 4; }
		}
		
		public int ChunkZ
		{
			get { return FloorZ >> 4; }
		}
		
		public override string ToString()
		{
			return string.Format("{0} {1} {2}", X, Y, Z);
		}
	}
}
