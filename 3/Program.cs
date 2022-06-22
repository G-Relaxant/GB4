Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int product = 1;
for(int i = 1; i <= num; i++)
{
    product = product * i;
}
if(num >= 1)
{
    Console.Write("Произведение чисел от 1 до N: " + product);
}
else
{
    Console.Write("Вы ввели недопустимое число");
}    