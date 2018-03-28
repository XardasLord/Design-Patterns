using static System.Console;

namespace Decorator___Custom_String_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Decorator Pattern using by creating our own CodeBuilder which not really directly inherit from StringBuilder but uses the decorator
            // See the CodeBuilder class

            var cb = new CodeBuilder();
            cb.AppendLine("class Foo")
              .AppendLine("{")
              .AppendLine("}");
            WriteLine(cb);

            ReadLine();
        }
    }
}
