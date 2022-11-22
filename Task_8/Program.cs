int N = new int();
Console.WriteLine("Ведите число");
N = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (i < N - 1)
{
    i += 2;
    Console.WriteLine(i);
}
Console.Write("Все чётные числа");