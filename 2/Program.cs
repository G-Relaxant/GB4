Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int razr = 0;
double div = 10;

if(num > -1)
{
    Method(num, razr, div);
}
else
{
    num = num * -1;
    Method(num, razr, div);
}
//Console.Write("   " + int.MaxValue + "   " + double.MaxValue);



void Method(int a, int b, double c)
{
    for(int i = 1; i >= 1;)
{
    double x = Convert.ToDouble(i);
    double y = Convert.ToDouble(a);
    x = y / c;
    i = Convert.ToInt32(x);
    c = c * 10;
    b = b + 1;
}
Console.Write("В вашем числе " + b);
int remn = b % 10;
if(b > 9 && b < 21)
{
    Console.Write(" цифр");
}
else
{
    if(remn == 1)
    {
        Console.Write(" цифра");
    }
    else
    {
        if(remn > 1 && remn < 5)
        {
            Console.Write(" цифры");
        }
        else
        {
            if(remn >= 5)
            {
                Console.Write(" цифр");
            }
        }
    }        
}
}