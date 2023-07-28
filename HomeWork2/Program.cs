using HomeWork2;

//Money money = new Money(879, 125);

//Product product = new Product("Iphone14", money);
//product.ShowInfo();

//product.DecreasePrice(150, 150);

Violin violin = new Violin("Скрипка", "Дерево, струны");
Trombone trombone = new Trombone("Тромбон", "Метал");
Ukulele ukulele = new Ukulele("Укулеле", "Дерево, струны");
Cello cello = new Cello("Виолончель", "Дерево, струни");

// Виклик методів для відображення звуку, назви, характеристик та історії музичних інструментів
violin.Sound();
violin.Show();
violin.Desc();
violin.History();


trombone.Sound();
trombone.Show();
trombone.Desc();
trombone.History();


ukulele.Sound();
ukulele.Show();
ukulele.Desc();
ukulele.History();

cello.Sound();
cello.Show();
cello.Desc();
cello.History();
