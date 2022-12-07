// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int num = new Random().Next(10,100);
int a1 = num / 10;
int a2 = num % 10;

int max = a1;
if (max < a2)
{
    max = a2;
}
Console.WriteLine("Максимальная цифра в числе" + num + " -> " + max);