using System;

namespace Factory
{
    public class Point
    {
        private double x, y;

        // private constructor
        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
        }

        // Some properties to get directly from the Point class
        public static Point OriginProperty => new Point(0, 0); // better if we want to initializate the Point object every time we ask for it
        public static Point OriginField = new Point(0, 0); // better than above, because we initializate the Point object only once


        // We make this class inside the Point class, because we want to keep the Point constructor private
        public static class Factory
        {
            // factory method
            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }

            // factory method
            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(rho), theta * Math.Sin(theta));
            }
        }
    }
}
