using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    interface IFlying
    {
        void Fly(double speed); //метод летать - принимает аргумент скорость

        void Speak(); //метод разговаривать
    }
}
