Console.WriteLine("Введите число N: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for(int i = 1; i <= a; i++)
{
    sum += i; // sum = sum + i
}

Console.WriteLine(sum);
