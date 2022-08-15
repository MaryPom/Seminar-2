class Program {
 public static int Main() {
  Console.WriteLine("Введите число : ");
  int n =int.Parse(Console.ReadLine());
  int i = 0;
  while(n > 0) 
  {
   i++;
   n/=10;
  }
  Console.WriteLine("Количество цифр введенного числа : {0}", i);
  Console.ReadKey();
  return 0;
 }
}