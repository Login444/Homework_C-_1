Console.WriteLine("Посмотрим на все четные числа входящие в число N");
Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Итак число N равно {num}, вот все четные числа входящие в него: ");
int count = 1;
if (num>0)
{
    while (count <= num)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count}, ");
        count++;
    }
    else
    {
        count++;
    }
}
}
else
{
   while (count >= num)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count}, ");
        count = count - 1;
    }
    else
    {
        count = count - 1;
    }
} 
}