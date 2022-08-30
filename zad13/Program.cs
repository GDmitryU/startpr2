int num = new Random().Next(1, 50000);
int num3 = -1;
int num2 = -1;
int num1 = -1;
int number = num;
while (number > 0) {
    num3 = num2;
    num2 = num1;
    num1 = number % 10;
    number = number /10;
 }
if (num3 == -1) {
    Console.WriteLine($"Третьей цифры в числе {num} нет");
}
else {
    Console.WriteLine($"Третья цифра числа {num}: {num3}");
}
