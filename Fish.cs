using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    class Fish : ISwimming // будет плавать
    {
        public string name;
        public string color; // цвет 

        public Fish() : this ("NoName", "NoColor") // рыбка по умолчанию красная
        {
        }

        public Fish(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void Swim(int speed)
        {
            Console.WriteLine(name.ToString() + " плывёт в глубене со скоростью " + speed + " км/ч "); //данного класса toString
        }

        public void Speak()
        {
            Console.WriteLine(" Я плаваю и говорю Буль-Буль ");
        }

        public void Print()
        {
            Console.WriteLine(" Я - рыбка, у меня есть имя - " + name + " и цвет " + color);
        }
    }
}
