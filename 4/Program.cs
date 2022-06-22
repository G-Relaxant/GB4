// 1 вариант
/*int[] array = new int[8];
int length = array.Length;
int index = 0;
while (index < length)
{
    array[index] = new Random().Next(0, 2);
    index++;
}
index = 0;
Console.Write("[");
while (index < length)
{
    Console.Write(array[index]);
    index++;
    if(index < length)
    {
        Console.Write(",");
    }
    else
    {
        Console.Write("");
    }
}
Console.Write("]");*/




// 2 variant (проще и менее красивый + не точно удовлетворяет условиям задачи)
int[] array = new int[8];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.Write(array[i] + " ");
}