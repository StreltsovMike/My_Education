int[] array = new int[] { 170, 30, 400, 20, 50, 70, 1 };
var str = string.Join(" ", array);

 Console.WriteLine(str);

int size = 6,
    indexMax = size,
    index = 0,
    Max=0,
    max=0,
    X;

while (indexMax > 0)
{
    while (index < size)
    {

        if (array[index] > max)
        {
            max = array[index];
            Max = index;
        }
        index++;
    }
    X=array[indexMax];
    array[indexMax]=array[Max];
    array[Max]=X;
    indexMax-=1;

    str = string.Join(" ", array);
    Console.WriteLine(str);
    size-=1;
    max=0;
    index=0;
}


str = string.Join(" ", array);
Console.WriteLine("Отсортированный массив : " + str);