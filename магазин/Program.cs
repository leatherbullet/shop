using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace магазин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int cristal;
            int cristalPrice = 10;

            Console.Write("Сколько у вас золота?");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"стоимость кристалла:{cristalPrice} золота");
            Console.Write("сколько кристаллов вам нужно?");
            cristal = Convert.ToInt32(Console.ReadLine());
            
            gold -= cristal * cristalPrice;

            Console.WriteLine($"вы купили {cristal} кристаллов и у вас осталось {gold} золота");

        }
    }
}
