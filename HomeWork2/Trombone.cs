namespace HomeWork2
{
    internal class Trombone : MusInstrument
    {
        public Trombone(string _name, string _description) : base(_name, _description)
        {
        }

        public override void Sound()
        {
            Print("Tombone звучит так : BOM BOM BOM");
            Console.WriteLine();
        }

        public override void History()
        {
            Print("Тромбон - медный духовой музыкальный инструмент, созданный в XV веке в Европе. \n" +
                "Он произошел от ранних трубных инструментов и сначала был использован в военных оркестрах. \n" +
                "В последующие века его конструкция эволюционировала, \n" +
                "и он стал неотъемлемой частью симфонических, джазовых и других музыкальных ансамблей.");
            Console.WriteLine();
        }
    }
}
