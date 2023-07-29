
namespace HomeWork2
{
    internal class Cello : MusInstrument
    {
        public Cello(string _name, string _description) : base(_name, _description)
        {
        }
        //добавил override метод для практики
        public override void Sound()
        {
            Print("Cello звучит так : ТУДУ ТУДУ ТУДУ");
        }

        public override void History()
        {
            Print(InstrumentsResource.Cello);
        }
    }
}
