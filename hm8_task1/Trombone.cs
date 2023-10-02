using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm8_task1
{
    internal class Trombone : MusicalInstrument
    {
        public Trombone()
        {
            Description = "Trombone";
            HistoryOfCreation =
                "The trombone is a 15th-century development of the trumpet and, until approximately 1700, was known as the sackbut.\n" +
                "Like a trumpet, it has a cylindrical bore flared to a bell. Its mouthpiece is larger, however, suited to its deeper\n" +
                "musical register, and is parabolic in cross section, like a cornet.\n";
        }
        public override void Sound()
        {
            Console.WriteLine("High pitch of trombone sound.\n");
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
