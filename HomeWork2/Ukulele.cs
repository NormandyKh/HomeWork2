
namespace HomeWork2
{
    internal class Ukulele : MusInstrument
    {
        public Ukulele(string _name, string _description) : base(_name, _description)
        {
        }
        //добавил override метод для практики
        public override void Sound()
        {
            Print("Ukulele звучит так : LA LA LA");
        }

        public override void History()
        {
            Print(InstrumentsResource.Ukulele);
        }

    }
}
