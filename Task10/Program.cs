// Задача 10. Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите значение N: ");
int N = int.Parse(Console.ReadLine());

for (int i = 2; i <= N; i += 2)
{
    Console.WriteLine(i * i * i);
}