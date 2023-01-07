// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int N,M;
int sum = 0;

Console.WriteLine(" Задайте значения M и N. Программа найдёт сумму натуральных элементов в промежутке от M до N.");
Console.Write("Введите число M: ");
int.TryParse(Console.ReadLine(), out M);

Console.Write("Введите число N, большее, чем M: ");
int.TryParse(Console.ReadLine(), out N);
while (N<=M){
    Console.Write("Введите число N, большее, чем M: ");
    int.TryParse(Console.ReadLine(), out N);
}


for (int i=M;i<=N;i++){
    sum+=i;
}
Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N}: {sum}");
