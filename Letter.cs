using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7_Task5
{
    class Letter
    {
        private char ch = 'А';
        private int end;

        public Letter(int end)
        {
            End = end;
        }

        public int End { get => end; set => end = value; }

        public IEnumerable MyItr(int start, int end)
        {
            if(start <= 0)
            {
                start = 1;
            }

            if(end > this.end)
            {
                end = this.end;
            }

            if(start > end)
            {
                end = start;
            }
            for(int i = start; i<= end; i++)
            {
                yield return (char)(ch + i -1);
            }
        }
    }
}
