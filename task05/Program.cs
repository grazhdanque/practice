Console.WriteLine("Введите целое натуральное число");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num} ->");
int numrev = (num * -1);
while (numrev != num)
{
    Console.Write($"{numrev++}, ");
}
Console.WriteLine(num);