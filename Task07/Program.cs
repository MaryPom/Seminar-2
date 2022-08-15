// Задача 7. Определить количество цифр в числе
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int result = 0;

while(n >= 1)
{
    n = n / 10;
    result ++;
}
Console.WriteLine(result);