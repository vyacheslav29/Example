// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

//Например: 
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Программа возведения числа в квадрат");

Console.WriteLine("Пожалуйста введите целое число и нажмите Enter:");

string? numberString = Console.ReadLine();

int number = int.Parse(numberString!);

int sqrt = number * number;

Console.WriteLine("Квадрат числа " + number + " есть число " + sqrt);
