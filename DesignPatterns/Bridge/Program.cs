using Autofac;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bridge pattern allows you to connect different abstraction together

            var cb = new ContainerBuilder();
            cb.RegisterType<VectorRenderer>().As<IRenderer>()
                .SingleInstance();
            cb.Register((c, p) => new Circle(c.Resolve<IRenderer>(), p.Positional<float>(0)));

            using(var c = cb.Build())
            {
                var circle = c.Resolve<Circle>(new PositionalParameter(0, 5.0f));
                circle.Draw();
                circle.Resize(2);
                circle.Draw();
            }

            Console.ReadLine();
        }
    }
}
