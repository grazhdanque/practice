Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int div = num % 2;
if (div == 0)
{
    Console.WriteLine("Да");
}  
else
{
    Console.WriteLine("Нет");
}