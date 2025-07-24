using System.Drawing;

namespace Assignment_06___OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project:

            //Override the ToString Function to produce this output:   Point3D P = new Point3D(10, 10, 10);          Console.WriteLine(P.ToString());    Output: “Point Coordinates: (10, 10, 10)”.

            Point3D P1 = new Point3D(10, 10, 10);
            Console.WriteLine(P1.ToString());


            //Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).
            Point3D P2 = new Point3D();
            int x;
            int.TryParse(Console.ReadLine(), out x);
            P2.X = x;
            P2.Y = int.Parse(Console.ReadLine());



            //Try to use == If(P1 == P2)   Does it work properly? 

            if (P1 == P2)
            {
                Console.WriteLine("The two points are equal.");
            }
            else
            {
                Console.WriteLine("The two points are not equal.");
            }
            // will compare the two points reference not the values




            //Define an array of points and sort this array based on X & Y coordinates.
            Point3D[] points ={
                new Point3D(7, 8, 9),
                new Point3D(1, 2, 20),
                new Point3D(10, 11, 12),
                new Point3D(4, 5, 6),
                new Point3D(13, 14, 15)
            };
            Array.Sort(points);

            foreach (var point in points)
            {
                Console.WriteLine(point.ToString());
            }



            #endregion
        }
    }

}
