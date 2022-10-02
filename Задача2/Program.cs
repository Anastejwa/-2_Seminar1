// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);
if (numberA > numberB)
    {
    Console.WriteLine("Первое число " + numberA + " больше чем второе " + numberB);
    }
else
    {
    Console.WriteLine("Второе число " + numberB + " больше чем первое " + numberA);
    }

