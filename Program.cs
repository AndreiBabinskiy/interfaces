using System;

namespace Laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish();
            fish.Print();
            fish.Speak();
            fish.Swim(0);

            Console.WriteLine("---------------");
            Fish fish1 = new Fish("Lyly", "Red");
            fish1.Print();
            fish1.Speak();
            fish1.Swim(5);

            Console.WriteLine("------------------");
            Bird bird1 = new Bird();
            bird1.Print();
            bird1.Speak();
            bird1.Fly(0);

            Console.WriteLine("-----------------");
            Bird bird2 = new Bird("Biba", 10);
            bird2.Print();
            bird2.Speak();
            bird2.Fly(20.8);

            Console.WriteLine("--------------------");
            Duck duck = new Duck();
            duck.Print();
            duck.Speak();
            duck.Fly(0);
            duck.Swim(0);

            Console.WriteLine("----------------------");
            Duck duck1 = new Duck("Boba", 60, 25);
            duck1.Print();
            duck1.Speak();
            duck1.Fly(40.6);
            duck1.Swim(30);

            Console.WriteLine("----------------------");
            Bird duck2 = new Duck("Gura", 5, 35);
            duck2.Print();
            duck2.Speak();
            duck2.Fly(35.5);

            Console.WriteLine("----------------------");
            Bird duck3 = new Duck("Fila", 17, 40);
            duck3.Print();
            duck3.Speak();// сделала как птица
            ((IFlying)duck3).Speak();
            ((ISwimming)duck3).Speak();
            Console.WriteLine("_-_-_-_-_-_->>>>>>>>>");
            Duck duck4 = new Duck("Lulu", 58, 60);
            duck4.DuckFlyingSpeak();
            duck4.DuckSwimingSpeak();

            Console.WriteLine("><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            IFlying[] birds = new IFlying[6]
            {
                new Bird(),
                new Duck("Numa", 50, 40),
                new Bird("Fuput", 70),
                new Duck(),
                new Bird("Pura", 5),
                new Duck("Mina", 90,90)
            };

            foreach(IFlying bird in birds)
            {
                Console.WriteLine(bird.ToString());
                Console.WriteLine("-----------");
                if (bird is Duck) //is - да или нет
                {
                    ((Duck)bird).Print();
                }
                else
                {
                    ((Bird)bird).Print();
                }

                //(bird as ISwimming)?.Swim(3); -->

                if(bird is ISwimming)
                {
                    ((ISwimming)bird).Swim(3);
                }
                Console.WriteLine();
            }
            Console.WriteLine("___------------------------------_____________--------------------");
            Bird[] birdsAll = new Bird[6]
            {
                new Bird(),
                new Duck("Popa", 80, 50),
                new Bird("Gara", 40),
                new Duck(),
                new Bird("Mutsa", 8),
                new Duck("Lina", 70,30)
            };
            foreach (Bird br in birdsAll)
            {
                br.Print();
            }

            Console.WriteLine("_________________________________");
            Array.Sort(birdsAll);
            foreach(Bird br in birdsAll)
            {
                br.Print();
            }

            Console.WriteLine("_________________________________");
            Array.Sort(birdsAll, new ComparerBirdByLengthOfName());
            foreach (Bird br in birdsAll)
            {
                br.Print();
            }

            Console.WriteLine("_________________________________");
            Array.Sort(birdsAll, new ComparerBirdByLengthOfAge());
            foreach (Bird br in birdsAll)
            {
                br.Print();
            }
        }
    }
}
