
namespace HomeWork2
{
    internal class Ukulele : MusInstrument
    {
        public Ukulele(string _name, string _description) : base(_name, _description)
        {
        }

        public override void Sound()
        {
            Print("Ukulele звучит так : LA LA LA");
            Console.WriteLine();
        }

        public override void History()
        {
            Print("Укулеле - маленький струнный инструмент с гавайскими корнями,\n" +
                " разработанный в конце XIX века в результате слияния португальской брагиньи с местными инструментами Гавайских островов.");
            Console.WriteLine();
        }

    }
}
