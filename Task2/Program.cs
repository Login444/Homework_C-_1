Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine($"Число {num1} наибольшее");
    }
    else
    {
        Console.WriteLine($"Число {num3} наибольшее");
    }
}
else
{
    if (num1 > num3)
    {
        Console.WriteLine($"Число {num2} наибольшее");
    }
    else
    {
        if (num3>num2)
        {
            Console.WriteLine($"Число {num3} наибольшее");
        }
        else
        {
            Console.WriteLine($"Число {num2} наибольшее");
        }
    }
}