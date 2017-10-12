using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            //          ТИПЫ

            byte bt = 1;
            sbyte sbt = 2;
            int i = 10;
            uint ui = 12;
            short sh = 14;
            ushort ush = 16;
            string str = "asd";
            char ch = 'a';
            float fl = 12.11F;
            double db = 12.1214;
            bool bl = true;
            long lg = 1241513523;
            ulong ulg = 2141342535434;
            decimal dec = 894_596_257_687_111_233;

            i = bt;
            i = sh;
            lg = i;
            dec = i;
            db = fl;

            i = (int)ui;
            lg = (long)ulg;
            sh = (short)ush;
            fl = (float)db;
            lg = (long)dec;

            Object objInt = i;
            int i2 = (int)i;
            Console.WriteLine(i2);

            var a = 12;
            var b = 'b';

            int? varNull = null;
            int? varNull2 = null;
            if (varNull.HasValue)
            {
                Console.WriteLine(varNull == varNull2);
            }

            //          СТРОКИ
            Console.WriteLine("--------СТРОКИ----------");
            string str1 = "asd";
            Console.Write("Сравнение строк '{0}' и '{1}': ", str, str1);
            if (str == str1)
                Console.WriteLine("равны");
            else
                Console.WriteLine("не равны");

            string s1 = "Строка 1 ";
            string s2 = "Строка 2 ";
            string s3 = "Строка 3 ";

            string concatString = string.Concat(s1, s2);
            Console.WriteLine("Конкатенация '{0}' и '{1}': '{2}'", s1, s2, concatString);
            string copyString = string.Copy(s3);
            Console.WriteLine("Копирование: '{0}'", copyString);
            string subString = concatString.Substring(3, 10);
            Console.WriteLine("Выделение подстроки: '{0}'", subString);
            string[] splitString = concatString.Split(' ');
            Console.WriteLine("Разделение строки на слова: '{0}', '{1}', '{2}', '{3}'", splitString[0], splitString[1], splitString[2], splitString[3]);
            string insertString = s3.Insert(4, s3);
            Console.WriteLine("Вставка подстроки: '{0}'", insertString);
            string remString = concatString.Remove(0, s1.Length);
            Console.WriteLine("Удаление подстроки '{0}' из '{1}': {2} ", s1, concatString, remString);


            string nullStr = null;  // можно исп в операциях объединения и сравнения
            string emptyStr = "";   // можно вызывать методы

            int len = emptyStr.Length;
            Console.WriteLine(nullStr == emptyStr);

            StringBuilder sb = new StringBuilder("ASD", 20);
            sb.Insert(0, "asd");
            sb.Insert(sb.Length, "asd");
            sb.Append(new char[] { 'A', 'S', 'D' });
            Console.WriteLine(sb);
            sb.Remove(2, 1);
            Console.WriteLine(sb);

            //              МАССИВЫ
            Console.WriteLine("--------МАССИВЫ----------");
            Console.WriteLine("\n-- Задание А");
            int[,] m = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (i = 0; i < 3; i++)
            {
                Console.Write('(');
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" {0} ", m[i, j]);
                }
                Console.WriteLine(')');
            }

            Console.WriteLine("\n-- Задание В");
            String[] ms = new String[] { "Строка 1", "Строка 2", "Строка 3" };
            foreach (String x in ms)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Длина массива: {0}", ms.Length);
            ms[1] = "Строка 4";
            foreach (String x in ms)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\n-- Задание C");
            double[][] mf = new double[3][] { new double[2], new double[3], new double[4] };
            /*for (i = 0; i < mf.Length; i++)
            {
                for (int j = 0; j < mf[i].Length; j++)
                {
                    Console.Write($"myArr[{i}][{j}] = ");
                    mf[i][j] = Convert.ToDouble(Console.ReadLine());
                }
            }*/

            var vmas = new[] { 1, 2, 3, 4, 5 };
            var vstr = new[] { "asdqwe" };

            //          КОРТЕЖИ
            Console.WriteLine("--------КОРТЕЖИ----------");
            ValueTuple <int, string, char, string, ulong> corteg = (first:7, second:"asd", third:'v', fourth:"rtuhr", fifth:4);
            (int first, string second, char third, string fourth, ulong fifth) corteg2 = (7, "asd", 'v', "rtuhr", 4);      // именование при объявлении

            Console.WriteLine($"Вывод всего кортежа: {corteg}");
            Console.WriteLine($"Выборочный вывод: {corteg.Item1}, {corteg.Item2}, {corteg.Item3}");

            (var a1, var b1, var c1, var d1, var e1) = corteg2;     // распаковка
            Console.WriteLine($"{a1}, {b1}");

            if (Equals(corteg, corteg2))
            {
                Console.WriteLine("Кортежы равны");
            }


            (int, int, int, char) LocFun(int[] array, string s)
            {
                int max = 0, min = 0, sum = 0;
                char letter;
                for (i = 1; i < array.Length; i++)
                    if (array[max] < array[i])
                        max = i;
                for (i = 1; i < array.Length; i++)
                    if (array[min] > array[i])
                        min = i;
                for (i = 0; i < array.Length + 1; i++)
                    sum += i;
                letter = s[0];

                return (array[max], array[min], sum, letter);
            }

            var cor = LocFun(vmas, s1);
            Console.WriteLine($"{cor}");
        }
    }
}
