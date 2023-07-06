Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) 
{
    num *= -1;
}
if (num >= 100 && num <= 999)
{
Console.WriteLine($"{num} -> {num % 10}");
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}