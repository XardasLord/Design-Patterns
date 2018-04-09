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

            // This is the dynamic strategy (at runtime)
            var tp = new TextProcessor();
            tp.SetOutputFormat(OutputFormat.Markdown);
            tp.AppendList(list);
            Console.WriteLine(tp);

            tp.Clear();
            tp.SetOutputFormat(OutputFormat.Html);
            tp.AppendList(list);
            Console.WriteLine(tp);

            // You can also delegate it to the Dependency Injection Container like this (good way)
            // This is how it's typically done in the real world:
            // It is defined at compile time, not at runtime:
            //
            // cb.Register<MarkdownListStrategy>().As<IListStrategy>();



            Console.ReadLine();
        }
    }
}
