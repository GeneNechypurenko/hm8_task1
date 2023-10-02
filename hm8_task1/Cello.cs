using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm8_task1
{
    internal class Cello:MusicalInstrument
    {
        public Cello()
        {
            Description = "Cello";
            HistoryOfCreation =
                "No one knows for sure when exactly the first cello was created. However, based on the instrument's first mention\n" +
                "in writing, we know that it was being used at the beginning of the 16th century. At first it appears that the\n" +
                "instrument was called the bass viola da braccio ('viola for the arm').\n";
        }
        public override void Sound()
        {
            Console.WriteLine("Deep sound of cello.\n");
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
