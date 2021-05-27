using System;

namespace ConsoleShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            var user = new Customer("Jaunius", 200);

            shop.ListItems();

            shop.Buy("ItemName", 20);

            shop.LoadItems();

            var sum = CalculatorLib.SumNumbers(20, 5);

        }
    }
}
