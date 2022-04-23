using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    class Duck : Bird, ISwimming, IFlying //коллизия
    {
        private double weight;

        public Duck() : base("NoName", 0)
        {        
            Weight = 0.1;
        }

        public Duck(string name, int age, double weight) : base(name, age)
        {
            Weight = weight;
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    weight = value;
                }
                else
                {
                    weight = 0.5;
                }
            }
        }
        public void Swim(int speed)
        {
            Console.WriteLine(Name.ToString() + " плывёт по поверхности воды со скоростью " + speed + " км/ч "); //данного класса toString
        }

        public override void Speak() // склеивание
        {
            Console.WriteLine(" Говорю Кря-Кря");
        }

        void IFlying.Speak() // кастинг
        {
            Console.WriteLine(" Я лечу и говорю Кря-Кря-Кря-Кря-Кря");
        }

        void ISwimming.Speak() // кастинг
        {
            Console.WriteLine(" Я плыву и говорю Кря-Буль-Кря-Буль-КРЯ-Буль-кря");
        }

        public void DuckFlyingSpeak() //кастинг + обертывание
        {
            ((IFlying)this).Speak();
        }

        public void DuckSwimingSpeak() //кастинг + обертывание
        {
            ((ISwimming)this).Speak();
        }

        public new void Print()
        {
            Console.WriteLine(" Я - утка, у меня есть имя - " + Name + ", возраст " + Age + " лет " + " и весом в " + weight + " кг ");
        }
    }
}
