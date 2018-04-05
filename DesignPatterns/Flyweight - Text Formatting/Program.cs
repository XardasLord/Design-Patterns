using static System.Console;

namespace Flyweight___Text_Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            var ft = new FormattedText("This is a brave new world");
            ft.Capitalize(10, 15);
            WriteLine(ft);

            var bft = new BetterFormattedText("This is a brave new world");
            bft.GetRange(10, 15).Capitalize = true;
            WriteLine(bft);

            ReadLine();
        }
    }
}
