// See https://aka.ms/new-console-template for more information

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());


void writeNumbersRecurrecntly(int N){
    if (N>=1){      
        Console.Write($"{N} ");
        writeNumbersRecurrecntly(N-1);
    }
};

Console.Write("Вывод N чисел: ");
writeNumbersRecurrecntly(N);