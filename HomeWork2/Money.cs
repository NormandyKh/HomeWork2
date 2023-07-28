//namespace HomeWork2
//{
//    internal class Money
//    {
//        private int _dollars;
//        private int _cents;

//        //конструктор
//        public Money(int _dollars, int _cents)
//        {
//            // если центов больше чем 100 добавляем доллар и оставшиеся центы
//            this._dollars = _dollars + _cents / 100;
//            this._cents = _cents % 100;
//        }

//        //публичное свойство
//        public int Dollars
//        {
//            get { return _dollars; }
//        }

//        //публичное свойство
//        public int Cents
//        {
//            get { return _cents; }
//        }

//        //метод показывает баланс
//        public void ShowBalance()
//        {
//            Console.WriteLine($"Sum: {_dollars} долларов и {_cents} центо");
//        }

//        //метод для добаления денег на счет
//        public void SetBalance(int _dollars, int _cents)
//        {
//            // если центов больше чем 100 добавляем доллар и оставшиеся центы
//            this._dollars = _dollars + _cents / 100;
//            this._cents = _cents % 100;
//        }
//    }
//}
