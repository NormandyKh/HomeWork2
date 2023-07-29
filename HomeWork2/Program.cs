using HomeWork2;

//Money money = new Money(879, 125);

//Product product = new Product("Iphone14", money);
//product.ShowInfo();

//product.DecreasePrice(150, 150);

DecimalNumber number = new DecimalNumber(10);
Console.WriteLine("Десяткове число: " + number.DecimalValue);
Console.WriteLine("Двійкове число: " + number.ToBinary());
Console.WriteLine("Вісімкове число: " + number.ToOctal());
Console.WriteLine("Шістнадцяткове число: " + number.ToHexadecimal());