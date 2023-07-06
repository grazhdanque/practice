Console.WriteLine("Введите целое натуральное число");
double num = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (num <= 0) 
{
    Console.WriteLine("Число не является натуральным");
}
else while (count != num + 1)
{
    Console.Write($"{count} ");
    count += 1;
}