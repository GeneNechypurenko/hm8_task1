using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm8_task2
{
    internal abstract class Worker
    {
        protected string? Description { get; init; }
        public abstract void Print();
    }
}
