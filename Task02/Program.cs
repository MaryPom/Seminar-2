// Задача 2. По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse (Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse (Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine("Первое число является квадратом второго числа ");
}
else if (number2 == number1 * number1)
{
    Console.WriteLine("Второе число  является квадратом первого числа ");
}
else if ((number2 != number1 * number1) && (number1 != number2 * number2))
{
    Console.WriteLine("Ни одно из чисел не является квадратом для другого заданного числа");
}