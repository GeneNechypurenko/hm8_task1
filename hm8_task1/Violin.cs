using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm8_task1
{
    internal class Violin : MusicalInstrument
    {
        public Violin()
        {
            Description = "Violin";
            HistoryOfCreation =
                "The violin, viola and cello were first built in the early 16th century, in Italy.\n" +
                "The earliest evidence for their existence is in paintings by Gaudenzio Ferrari from the 1530s,\n" +
                "though Ferrari's instruments had only three strings.\n";
        }
        public override void Sound()
        {
            Console.WriteLine("The violin makes a beautiful sound.\n");
        }
        public override void Show()
        {
            Console.WriteLine($"A {Description}: \n{HistoryOfCreation}");
        }
        public override void Desc()
        {
            Console.WriteLine($"{Description}");
        }
        public override void History()
        {
            Console.WriteLine($"{HistoryOfCreation}");
        }
    }
}
