using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    interface ISwimming
    {
        void Swim(int speed); //метод плавать - принимает аргумент скорость

        void Speak(); //метод разговаривать (по методу Speak) - коллизия
    }
}
