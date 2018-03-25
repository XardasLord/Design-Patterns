using MoreLinq;
using System;
using System.Collections.Generic;

namespace Adapter
{
    class Program
    {
        private static readonly List<VectorObject> vectorObjects = new List<VectorObject>
        {
            new VectorRectangle(1,1,10,10),
            new VectorRectangle(3,3,6,6)
        };

        static void Main(string[] args)
        {
            Draw();
            Draw();

            Console.ReadLine();
        }

        // the interface we have
        public static void DrawPoint(Point p)
        {
            Console.WriteLine(".");
        }

        private static void Draw()
        {
            foreach (var vo in vectorObjects)
            {
                foreach (var line in vo)
                {
                    var adapter = new LineToPointAdapter(line);
                    adapter.ForEach(DrawPoint);
                }
            }
        }
    }
}
