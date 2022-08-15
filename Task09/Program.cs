// Задача 9. Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int x = 1;

for (int i = 1; i <= N; i++)
{
    x = x * i;
}
Console.WriteLine(x);