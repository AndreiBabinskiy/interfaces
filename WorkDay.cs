using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7_Task5
{
    class WorkDay
    {
        private int end;

        public WorkDay()
        {
            End = 7;
        }

        public WorkDay(string[] wordDay)
        {
            WordDays = wordDay;
        }

        public int End { get => end; set => end = value; }
        public string[] WordDays { get => wordDay; set => wordDay = value; }

        private string[] wordDay =
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

        public IEnumerable MyWorkDay(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if(i < 1 || i > WordDays.Length)
                {
                    yield break;
                }
                yield return (string)(WordDays[i - 1]);
            }
        }

    }
}
