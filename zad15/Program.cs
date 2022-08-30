Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Является ли день недели с номером {num} выхоным?");
if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5){
    Console.WriteLine("Нет");
}
if (num == 6 || num == 7){
    Console.WriteLine("Да");
}
