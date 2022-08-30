int num = new Random().Next(100, 1000);
int result = (num % 100) / 10;
Console.WriteLine($"Вторая цифра числа {num}: {result}");
