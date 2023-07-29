
namespace HomeWork2
{
    internal class Violin : MusInstrument
    {
        public Violin(string _name, string _description) : base(_name, _description)
        {
        }
        //добавил override метод для практики
        public override void Sound()
        {
            Print("Скрипка звучик так ТРУЛЮЛЮ");
        }

        public override void History()
        {
            Print(InstrumentsResource.Violin);
        }

    }
}
