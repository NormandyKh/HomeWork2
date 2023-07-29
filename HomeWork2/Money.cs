
namespace HomeWork2
{
    internal class Money
    {
        private int _dollars;
        private int _cents;

        //конструктор
        public Money(int _dollars, int _cents)
        {
            //проверяем  являются ли введеніе числа положительніми 
            if (!IsValidNumber(_dollars) || !IsValidNumber(_cents))
                throw new ArgumentException("Значения должны быть неотрицательными числами.");

            SetAmount(_dollars, _cents);
        }

        //публичное свойство
        public int Dollars
        {
            get { return _dollars; }
            set
            {
                if (IsValidNumber(value))
                    _dollars = value;
                else
                    throw new ArgumentException("Значение должно быть неотрицательным числом.");
            }
        }

        //публичное свойство
        public int Cents
        {
            get { return _cents; }
            set
            {
                if (IsValidNumber(value))
                    _cents = value;
                else
                    throw new ArgumentException("Значение должно быть неотрицательным числом.");
            }
        }

        //метод показывает баланс
        public void ShowAmount()
        {
            Console.WriteLine($"Sum: {_dollars} долларов и {_cents} центов");
        }

        //метод для добаления денег на счет
        public void SetAmount(int _dollars, int _cents)
        {
            // если центов больше чем 100 добавляем доллар и оставшиеся центы
            this._dollars = CentsToDollar(_dollars, _cents);
            this._cents = ConvertCents(_cents);     
        }

        private static bool IsValidNumber(int number) => number >= 0;

        private int CentsToDollar(int _dollars, int _cents) => _dollars += _cents / 100;

        public int ConvertCents(int _cents) => _cents % 100;

        public int CalculateTotalCents(int _dollars, int _cents) => _dollars * 100 + _cents;

        public int CalculateCents(int dollars, int cents) => dollars * 100 + cents;
        
        public int TotalCentsToDollars(int _cents) => _cents / 100;
    }
}
