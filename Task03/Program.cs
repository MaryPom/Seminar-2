// Задача 3. Задать номер четверти, показать диапазоны для возможных координат
Console.Write("Введите число n - номер четверти системы координат: ");
int n = int.Parse(Console.ReadLine());

if (n == 1)
{
    Console.WriteLine("В заданной четверти системы координат: x > 0; y > 0");
}
if (n == 2)
{
    Console.WriteLine("В заданной четверти системы координат: x < 0; y > 0");
}
if (n == 3)
{
    Console.WriteLine("В заданной четверти системы координат: x < 0; y < 0");
}
if (n == 4)
{
    Console.WriteLine("В заданной четверти системы координат: x > 0; y < 0");
}