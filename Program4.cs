using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Set l = new Set();
            Set l2 = new Set();
            Set l3 = new Set();
            Set l4 = new Set();
            Set.Date l7 = new Set.Date();
            l7 = new Set.Date();
            Set.Owner l8 = new Set.Owner("WhatIsLove");
            l8 = new Set.Owner();
            l.Insert("one");
            l.Insert("two");
            l.Insert("three");
            Console.WriteLine("1ое Множество: ");
            l.Show();
            l = l - 1;
            l2.Insert("one");
            l2.Insert("two1");
            l2.Insert("three1");
            Console.WriteLine("2ое Множество: ");
            l2.Show();
            l3.Insert("one");
            l3.Insert("two1");
            l3.Insert("three1");
            Console.WriteLine("3ее Множество: ");
            l3.Show();
            l4 = l * l2;
            Console.WriteLine("4ое Множество (пересечение): ");
            l4.Show();
            Console.WriteLine("2 равно 3? " + (l2 < l3));
            Console.WriteLine("2 равно 4? " + (l2 < l4));
            Console.WriteLine("1 Подмножество 4? " + (l4 > l));
            Console.WriteLine("4 Подмножество 2? " + (l2 > l4));
            Console.WriteLine("Оператор & (вывод) ");
            Set l5 = l & l2;
            Console.WriteLine("Обнуление 1ого:");
            MathObjects.NullMePls(l);
            l.Show();
            MathObjects.MaxPls(l3);
            MathObjects.MinPls(l3);
            MathObjects.AddDot(l3);
            l3.Show();
        }
    }
    public static class MathObjects
    {
        public static void NullMePls(Set t)
        {
            for (int i = 0; i < t.count; i++)
            {
                t.mn[i] = null;
                t.count--;
            }
        }
        public static void MaxPls(Set t)
        {
            int n = 0;
            for (int i = 0; i < t.count; i++)
            {
                if ((t.mn[i]).Length > n)
                {
                    n = (t.mn[i]).Length;
                }
            }
            Console.WriteLine("Наибольшая длина эл-та: " + n);
        }
        public static void AddDot(this Set t)
        {
            int n = 0;
            Console.WriteLine("Какому эл-ту добавить точку: ");
            n = Convert.ToInt32(Console.ReadLine());
            t.mn[n] += ".";
        }
        public static void MinPls(Set t)
        {
            int n = 99;
            for (int i = 0; i < t.count; i++)
            {
                if ((t.mn[i]).Length < n)
                {
                    n = (t.mn[i]).Length;
                }
            }
            Console.WriteLine("Наименьшая длина эл-та: " + n);
        }
    }
    public class Set
    {
        public struct Owner
        {
            public int id;
            public string name;
            public string company;
            public Owner(string name1)
            {
                Console.WriteLine("имя: " + name1);
                name = name1;
                Console.WriteLine("Введите организацию: ");
                company = Console.ReadLine();
                id = (name + company).GetHashCode();
                Console.WriteLine("Выданный id: " + id);
            }
        }
        public class Date
        {
            public DateTime dd = DateTime.Now;
        }
        public string[] mn = new string[50];
        public int count = 0;
        public Set()
        {

        }
        public void Insert(string r)
        {
            mn[count] = r;
            count++;
        }
        public void Insert(int r)       //Удаляет элемент по индексу
        {
            mn[r] = null;
            for (int i = r; i < count; i++)
            {
                mn[i] = mn[i + 1];
            }
            count--;
        }
        public void Show()       //Удаляет элемент по индексу
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(mn[i]);
            }
        }
        public static Set operator -(Set obj, int s)
        {
            obj.Insert(s);
            return obj;
        }
        public static Set operator *(Set obj1, Set obj2)
        {
            Set obj = new Set();
            for (int j = 0; j < obj1.count; j++)
            {
                string key1 = obj1.mn[j];
                for (int i = 0; i < obj2.count; i++)
                {
                    string key2 = obj2.mn[i];
                    if (key1 == key2)
                    {
                        obj.Insert(key1);
                    }
                }
            }
            return obj;
        }
        public static Set operator &(Set obj1, Set obj2)
        {
            Set t = new Set();
            obj1.Show();
            obj2.Show();
            return t;
        }
        public static bool operator >(Set obj1, Set obj2)   //obj2 ~ подмноество
        {
            int g = 0; int s = 0;
            if (obj1.count == obj2.count || obj1.count > obj2.count)
            {
                for (int i = 0; i < obj2.count; i++)
                {
                    string key2 = obj2.mn[i];
                    for (int j = 0; j < obj1.count; j++)
                    {
                        string key1 = obj1.mn[j];
                        if (key2 != key1) { s++; Console.WriteLine("!"); }
                        else Console.WriteLine(":)");
                    }
                    if (s == (obj1.count)) { g++; }
                }
            }
            else
            {
                g = 1;
                Console.WriteLine("!");
            }
            if (g > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool operator <(Set obj1, Set obj2)
        {
            int g = 0;
            if (obj1.count == obj2.count)
            {
                for (int j = 0; j < obj1.count; j++)
                {
                    string key1 = obj1.mn[j];
                    string key2 = obj2.mn[j];
                    if (key1 != key2)
                    {
                        g++;
                    }
                }
            }
            else
            {
                g = 1;
            }
            if (g > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

