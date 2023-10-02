using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm8_task1
{
    internal class Ukulele : MusicalInstrument
    {
        public Ukulele()
        {
            Description = "Ukulele";
            HistoryOfCreation =
                "It all started in 1879 when a group of immigrants arrived in Hawaii from Madeira. Stories have it that either\n" +
                "Augusto Dias or João Fernandes or both upon disembarking began playing musical instruments as their way of thanking\n" +
                "God for their safe passage.\n";
        }
        public override void Sound()
        {
            Console.WriteLine("Ukulele guitar sound.\n");
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
