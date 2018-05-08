using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            var seec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());
            var seconds = seec1 + sec2 + sec3;
            var minutes = 0;
            if (seconds > 59)
            {
                minutes = minutes+1;
                seconds = seconds - 60;
            }
            if (seconds > 59)
            {
                minutes = minutes + 1;
                seconds = seconds - 60;
            }
                Console.WriteLine("{0:0}:{1:00}", minutes , seconds);
        }
    }
}
