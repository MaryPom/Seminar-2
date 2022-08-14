// Задача 5. Найти кубы чисел от 1 до N
Console.WriteLine("Введите значение N: ");
int N = int.Parse(Console.ReadLine());
int count = 1;

while(count <= N)
{
    Console.WriteLine(count * count * count);
    count++;
}