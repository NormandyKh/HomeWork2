using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Cello : MusInstrument
    {
        public Cello(string _name, string _description) : base(_name, _description)
        {
        }

        public override void Sound()
        {
            Print("Cello звучит так : ТУДУ ТУДУ ТУДУ");
            Console.WriteLine();
        }

        public override void History()
        {
            Print("Виолончель - один из самых древних музыкальных инструментов, \n" +
                "развивавшийся на протяжении веков и происходящий из семейства скрипок и виол.");
            Console.WriteLine();
        }
    }
}
