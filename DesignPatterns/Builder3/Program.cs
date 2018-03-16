using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Facated Builder

            var pb = new PersonBuilder();
            Person person = pb
                .Lives.At("Królewiecka")
                      .In("Elbląg")
                      .WithPostCode("82-300")
                .Works.At("Office")
                      .AsA("Secretary")
                      .Earning(3000);

            Console.WriteLine(person);
            Console.ReadKey();
        }
    }
}
