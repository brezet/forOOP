using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Растение, Куст,Цветок,Роза,Гладиолус,Кактус,Бумага,Букет

namespace С_Sharp
{
    static class Printer
    {
        public static void iAmPrinting(object obj)
        {
            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bouquet first = new Bouquet();
            Console.WriteLine("Первый букет создан: " + first.TimeCreate());
            Plant tree = new Plant();
            Bush kustic = new Bush();
            Flower beautiful = new Flower();
            Rose mlong = new Rose();
            Glad n = new Glad();
            Cactus veryGreen = new Cactus();
            Paper list = new Paper();

            tree.Color = "Dark Green тЫ Питух";
            kustic.Size = 5;
            beautiful.Name = "Cvetoc4ek";
            mlong.Type = "Плетистая";
            n.Type = "Гладиолус обыкновенный";
            n.Color = "Красный";
            n.Year = "10/12/2001";
            veryGreen.Green = 10;
            list.Height = 5;
            Console.WriteLine(tree.ToString());
            Console.WriteLine(kustic.ToString());
            Console.WriteLine(beautiful.ToString());
            Console.WriteLine(mlong.ToString());
            Console.WriteLine(n.ToString() + " ||| ЦВЕТ: " + n.Color + " | Дата высадки: " + n.Year);
            Console.WriteLine(veryGreen.ToString());
            Printer.iAmPrinting(list);
            if (mlong is Bush)     //проверка можно ли привести
            {
                Bush test = mlong as Bush;       //проверяет, и, если можно, приводит к типу. Если нельзя - null
                Console.WriteLine(test.ToString());
            }
            else Console.WriteLine("Приведение не удалось");
            if (list is Bush)     //проверка можно ли привести
            {
                Bush test = mlong as Bush;       //проверяет, и, если можно, приводит к типу. Если нельзя - null
                Console.WriteLine(list.ToString());
            }
            else Console.WriteLine("Приведение не удалось");
        }
    }
}