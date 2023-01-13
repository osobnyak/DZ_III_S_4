// задаём массив из 8 элементов и выводим их на экран

int [] num = new int [8];

Console.WriteLine("Ведите min значение рандома");
int rndMin = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите max значение рандома");
int rndMax = Convert.ToInt32(Console.ReadLine());

if (rndMin > rndMax)
{
    int rndMin2 = rndMin;
    int rndMax2 = rndMax;
    rndMin = rndMax2;
    rndMax = rndMin2;
}

for (int i = 0; i < num.Length; i++)
{
    num[i] = new Random().Next(rndMin, (rndMax+1));
    Console.Write($"{num[i]} ");
 }
   Console.WriteLine();