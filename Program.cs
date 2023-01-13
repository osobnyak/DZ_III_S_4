// Задача 27. принимаем число и выдаём сумму цифр в числе.

Console.WriteLine("Ведите число");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 0) { x = x * -1; } else { x = x * 1; }

int i = 10;
int sum = 0;


int res1 = x % 10;
//if (res1 < 0) {res1 = res1 * -1;} else {res1 = res1 * 1;}
Console.Write("последне число = ");
Console.WriteLine(res1);
sum = sum + res1;

while (x > i)
{
    int res3 = x / i % 10;
    // if (res3 < 0){res3 = res3 * -1;}else{res3 = res3 * 1;}
    Console.Write("перед ним = ");
    Console.WriteLine(res3);
    sum = sum + res3;
    i = i * 10;
}

Console.Write("сумма чисел = ");
Console.WriteLine(sum);
