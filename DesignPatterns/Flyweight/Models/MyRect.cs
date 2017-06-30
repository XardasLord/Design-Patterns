using System.Drawing;

namespace Flyweight.Models
{
    public class MyRect
    {
        private Color _color;
        private int _x, _y, _x2, _y2;

        public MyRect(Color color)
        {
            _color = color;
        }

        public void Draw(Graphics g, int upperX, int upperY, int lowerX, int lowerY)
        {
            SolidBrush brush = new SolidBrush(_color);
            g.FillRectangle(brush, upperX, upperY, lowerX, lowerY);
        }

        //public MyRect(Color color, int upperX, int upperY, int lowerX, int lowerY)
        //{
        //    _color = color;
        //    _x = upperX;
        //    _y = upperY;
        //    _x2 = lowerX;
        //    _y2 = lowerY;
        //}

        //public void Draw(Graphics g)
        //{
        //    SolidBrush brush = new SolidBrush(_color);

        //    g.FillRectangle(brush, _x, _y, _x2, _y2);
        //}
    }
}
