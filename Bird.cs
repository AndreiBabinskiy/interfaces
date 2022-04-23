using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    class Bird : IFlying, IComparable
    {
        public string Name;
        private int age;

        public Bird() : this("Noname", -1)
        {
        }

        public Bird(string name, int age)
        {
            this.Name = name;
            Age = age;
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }
        }

        public void Fly(double speed)
        {
            Console.WriteLine(Name.ToString() + " летит на высоте со скоростью " + speed + " км/ч "); //данного класса toString
        }

        public virtual void Speak()
        {
            Console.WriteLine(" Я летаю и говорю Чик-Чирик");
        }

        public void Print()
        {
            Console.WriteLine(" Я - птичка, у меня есть имя - " + Name + " и возраст " + age + " лет ");
        }

        public int CompareTo(object obj)
        {
            return this.Name.CompareTo(((Bird)obj).Name);
        }
    }

    class ComparerBirdByLengthOfName : IComparer<Bird>
    {
        public int Compare(Bird x, Bird y)
        {
            if (x.Name.Length < y.Name.Length)
            {
                return -1;
            }
            if (x.Name.Length > y.Name.Length)
            {
                return 1;
            }
            return 0;

            //return x.Name.Length.CompareTo(y.Name.Length); - иначе
        }
    }

    class ComparerBirdByLengthOfAge : IComparer<Bird>
    {
        public int Compare(Bird x, Bird y)
        {
            if (x.Age < y.Age)
            {
                return -1;
            }
            if (x.Age > y.Age)
            {
                return 1;
            }
            return 0;

            //return x.Age.CompareTo(y.Age); - иначе
        }
    }
}
