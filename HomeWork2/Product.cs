
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
            _price.ShowAmount();
        }

        //скидка на товар(изменение суммы товара)
        public void DecreasePrice(int dollars, int cents)
        {
            //переводим доллары в центы для последующего изменения цены
            int totalCents = _price.CalculateTotalCents(_price.Dollars, _price.Cents);
            int decreaseCents = _price.CalculateCents(dollars,cents);

            totalCents -= decreaseCents;

            if (totalCents < 0)
            {
                Console.WriteLine("Цена не может быть отрицательной.");
                return;
            }

            dollars = _price.TotalCentsToDollars(totalCents);
            cents = _price.ConvertCents(totalCents);

            _price.SetAmount(dollars, cents);
            Console.WriteLine($"Цена товара со скидкой: {dollars} долларов {cents} центов");
        }
    }
}
