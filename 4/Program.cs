int[] array = new int[8];
int lenght = array.Length;
int index = 0;
while (index < lenght)
{
    array[index] = new Random().Next(0, 2);
    index++;
}
index = 0;
Console.Write("[");
while (index < lenght)
{
    Console.Write(array[index]);
    index++;
    if(index < lenght)
    {
        Console.Write(",");
    }
    else
    {
        Console.Write("");
    }
}
Console.Write("]");