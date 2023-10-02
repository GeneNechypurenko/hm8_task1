using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm8_task1
{
    internal abstract class MusicalInstrument
    {
        protected string? Description { get; init; }
        protected string? HistoryOfCreation { get; init; }
        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
        public abstract void History();
    }
}
