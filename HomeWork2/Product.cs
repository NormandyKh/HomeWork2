
namespace HomeWork2
{
    internal class Product
    {
        private string _name;
        private Money _price;

        //конструктор
        public Product(string _name, Money _price)
        {
            this._name = _name;
            this._price = _price;
        }

        //метод показывает информацию и сумму тоара
        public void ShowInfo()
        {
            Console.WriteLine($"Название товара: {_name}");
            Console.Write("Цена товара: ");
            _price.ShowBalance();
        }

        //скидка на товар(изменение суммы товара)
        public void DecreasePrice(int dollars, int cents)
        {
            //переводим доллары в центы для последующего изменения цены
            int totalCents = _price.Dollars * 100 + _price.Cents;
            int decreaseCents = dollars * 100 + cents;

            totalCents -= decreaseCents;

            if (totalCents < 0)
            {
                Console.WriteLine("Цена не может быть отрицательной.");
                return;
            }

            dollars = totalCents / 100;
            cents = totalCents % 100;

            _price.SetBalance(dollars, cents);
            Console.WriteLine($"Цена товара со скидкой: {dollars} долларов {cents} центов");
        }
    }
}
