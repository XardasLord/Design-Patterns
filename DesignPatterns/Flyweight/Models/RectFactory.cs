using System.Collections.Generic;
using System.Drawing;

namespace Flyweight.Models
{
    public class RectFactory
    {
        private static Dictionary<Color, MyRect> rectsByColor = new Dictionary<Color, MyRect>();

        public static MyRect GetRect(Color color)
        {
            MyRect rect;
            rectsByColor.TryGetValue(color, out rect);

            if(rect == null)
            {
                rect = new MyRect(color);

                rectsByColor.Add(color, rect);
            }

            return rect;
        }
    }
}
