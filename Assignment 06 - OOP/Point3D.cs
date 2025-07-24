namespace Assignment_06___OOP
{
    public class Point3D: IComparable<Point3D> , ICloneable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public Point3D(int x, int y)
        {
            X = x;
            Y = y;
            Z = 0;
        }
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(Point3D? other)
        {
            return (X, Y).CompareTo((other?.X ?? 0, other?.Y ?? 0));
        }
      
        public object Clone()
        {
            return new Point3D(this.X, this.Y, this.Z);
        }
    }

}
