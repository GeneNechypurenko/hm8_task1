﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm8_task2
{
    internal class Manager : Worker
    {
        public Manager() { Description = "Manager"; }
        public override void Print()
        {
            Console.WriteLine(Description);
        }
    }
}
