using HomeWork2;

Money money = new Money(879, 125);

Product product = new Product("Iphone14", money);
product.ShowInfo();

product.DecreasePrice(150, 150);
