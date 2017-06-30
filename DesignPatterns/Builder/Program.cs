using Builder.Models;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemBuilder products = new ItemBuilder("Products");

            products.AddChild("Produce");
            products.AddChild("Orange");
            products.AddItemInformation("Price", "$1.00");
            products.AddItemInformation("Stock", "100");

            products.AddSibling("Apple");
            products.AddSibling("Grape");

            products.EditThisItem("Products");
            products.AddChild("Cereal");
            products.AddChild("Special K");
            products.AddItemInformation("Price", "$4.00");
            products.AddSibling("Raisin Bran");
            products.AddItemInformation("Price", "$4.00");
            products.AddSibling("Fiver One");
            products.AddItemInformation("Price", "$4.00");

            products.DisplayAllItems();

            Console.WriteLine($"\n{products.GetItemByName("Cereal")}");


            Console.ReadKey();
        }
    }
}
