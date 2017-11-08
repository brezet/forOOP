using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Растение, Куст,Цветок,Роза,Гладиолус,Кактус,Бумага,Букет

namespace С_Sharp
{
    public class Plant : IYear
    {
        private string _color;  //code convention

        public override int GetHashCode()
        {
            return _color.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return Color == ((Plant)obj).Color;
        }
        public override string ToString()
        {
            return "Color: " + Color + " | Тип: " + this.GetType();
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public void Break()     //Метод и сво-ва от интерфейса ↓↓↓
        {
            Color = "none";
        }
        string _year;
        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }                       //                            ↑↑↑↑
    }
    public class Bush : Plant   //Куст
    {
        private int _size;

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public override string ToString()
        {
            return "Size: " + Size + " | Тип: " + this.GetType();
        }

    }
    public class Flower : Bush //Цветок наследуется от Растения и куста
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public override string ToString()
        {
            return "Name: " + Name + " | Тип: " + this.GetType();
        }
    }
    public class Rose : Flower
    {
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public override string ToString()
        {
            return "Type: " + Type + " | Тип: " + this.GetType();
        }
    }
    public class Glad : Flower
    {
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public override string ToString()
        {
            return "Type: " + Type + " | Тип: " + this.GetType();
        }
    }
    public class Cactus : Bush
    {
        private int _green;

        public int Green
        {
            get { return _green; }
            set { _green = value; }
        }
        public override string ToString()
        {
            return "Green: " + Green + " | Тип: " + this.GetType();
        }
    }
    public sealed class Paper : Plant
    {
        private int _height;

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public override string ToString()
        {
            return "Height: " + Height + " | Тип: " + this.GetType();
        }
    }
    public class Bouquet : BouquetAbst
    {
        private int _count;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        public override void Add(int num)
        {
            Count += num;
        }
        public override string ToString()
        {
            return "Count: " + Count + " | Тип: " + this.GetType();
        }
    }

}