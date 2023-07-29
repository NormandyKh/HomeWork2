namespace HomeWork2
{
    internal class Trombone : MusInstrument
    {
        public Trombone(string _name, string _description) : base(_name, _description)
        {
        }

        public override void Sound()
        {
            Print("Trombone звучит так: BOM BOM");
        }
        //добавил override метод для практики
        public override void History()
        {
            Print(InstrumentsResource.Trombone);
        }
    }
}
