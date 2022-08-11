// Задача 1. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите номер дня недели: ");
int a = int.Parse (Console.ReadLine());

if (a == 6)
{
    Console.WriteLine("Суббота! Это выходной день");
}
else if (a == 7)
{
    Console.WriteLine("Воскресенье! Это выходной день!");
}
else if (a < 6)
{
    Console.WriteLine("Это рабочий день.");
}
