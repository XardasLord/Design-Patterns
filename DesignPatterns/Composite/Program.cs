using static System.Console;

namespace Composite_Geometric_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var drawing = new GraphicObject { Name = "My Drawing" };
            drawing.Children.Add(new Square { Color = "Red" }); // Good way is to implement helper method and call something like `drawing.AddChild()`
            drawing.Children.Add(new Circle { Color = "Yellow" });

            var group = new GraphicObject();
            group.Children.Add(new Circle { Color = "Blue" });
            group.Children.Add(new Square { Color = "Blue" });

            drawing.Children.Add(group);

            WriteLine(drawing);

            ReadLine();
        }
    }
}
