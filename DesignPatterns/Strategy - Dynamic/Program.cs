using System;

namespace Strategy___Dynamic
{
    public enum OutputFormat
    {
        Markdown,
        Html
    }

    class Program
    {
        static void Main(string[] args)
        {
            var list = new[] { "foo", "bar", "baz", "var" };

            var tp = new TextProcessor();
            tp.SetOutputFormat(OutputFormat.Markdown);
            tp.AppendList(list);
            Console.WriteLine(tp);

            tp.Clear();
            tp.SetOutputFormat(OutputFormat.Html);
            tp.AppendList(list);
            Console.WriteLine(tp);


            Console.ReadLine();
        }
    }
}
