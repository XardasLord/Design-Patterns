using Flyweight.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Flyweight
{
    public partial class Form1 : Form
    {
        private int _width = 1600;
        private int _height = 800;
        private Color[] _shapeColor = { Color.Orange, Color.Red, Color.Yellow, Color.Blue,
                                       Color.Pink, Color.Cyan, Color.Magenta, Color.Black, Color.Gray};
        private Random _random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Graphics g = drawingPanel.CreateGraphics();

            var watch = Stopwatch.StartNew();

            for (var i = 0; i < 100000; i++)
            {
                MyRect rect = RectFactory.GetRect(GetRandColor());
                rect.Draw(g, GetRandX(), GetRandY(), GetRandX(), GetRandY());
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine($"That took: {elapsedMs.ToString()}");
        }

        private Color GetRandColor()
        {
            Random randomGenerator = new Random();
            int randInt = randomGenerator.Next(9);

            return _shapeColor[randInt];
        }

        private int GetRandX()
        {
            return _random.Next(_width);
        }

        private int GetRandY()
        {
            return _random.Next(_height);
        }
    }
}
