using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm8_task2
{
    internal class Security : Worker
    {
        public Security() { Description = "Security"; }
        public override void Print()
        {
            Console.WriteLine(Description);
        }
    }
}
