using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jihanki
{
    class Program
    {
        static void Main(string[] args)
        {
            var jihanki = new Jihanki();
            while (true)
            {
                Console.WriteLine("");
                jihanki.ShowDrink();
                Console.WriteLine("\r\nよし！何番のドリンクを買おうかな！？");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine(jihanki.name[index] + " だね！" + jihanki.value[index] + "円払おう！！");
                jihanki.DrinkBuy(int.Parse(Console.ReadLine()), index);
            }
        }
    }
}
