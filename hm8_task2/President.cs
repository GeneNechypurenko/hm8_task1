using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm8_task2
{
    internal class President : Worker
    {
        public President()
        {
            Description = "President";
        }
        public override void Print()
        {
            Console.WriteLine(Description);
        }
    }
}
