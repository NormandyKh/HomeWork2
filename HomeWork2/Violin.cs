using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Violin : MusInstrument
    {
        public Violin(string _name, string _description) : base(_name, _description)
        {
        }

        public override void Sound()
        {
            Print("Скрипка звучик так ТРУЛЮЛЮ");
            Console.WriteLine();
        }

        public override void History()
        {
            Print("Скрипка - один из старейших музыкальных инструментов, \n" +
                "возникший в XVI-XVII веках в Италии и Германии, развиваясь из средневековых струнных инструментов.");
            Console.WriteLine();
        }

    }
}
