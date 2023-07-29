using HomeWork2;

//homework1
Money money = new Money(889, 125);
money.ShowAmount();

Product product = new Product("Iphone14", money);
product.ShowInfo();

product.DecreasePrice(150, 150);
