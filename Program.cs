// Задача 25. Напишите цикл: на входе 2 числа (А и В) и возводим число А в натуральную степень В.

Console.WriteLine("Ведите число А");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите число В");
int b = Convert.ToInt32(Console.ReadLine());

int res = 1;
int i = 0;

if (b<1)
{
    Console.WriteLine("значение В должно быть больше или равно 1");
}

else
{
    while (i < b)
    {
        res = res * a;
        //Console.WriteLine(res);    
        i++;
    }

    Console.WriteLine(res);
}