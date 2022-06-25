int[] array = new int[] { 170, 30, 400, 20, 50, 70, 1 };
var str = string.Join(" ", array);

int size = 6,
    indexMax = size,
    indexMin = 0,
    index2 = 1,
    X;

while (indexMax > indexMin)
{
    while (indexMax > indexMin)
    {
        if (array[indexMin] > array[index2])
        {
            X = array[index2];
            array[index2] = array[indexMin];
            array[indexMin] = X;
            index2++;
            indexMin++;
        }
        else if(array[indexMin] <= array[index2]) 
        {
            index2++;
            indexMin++;
        }

        str = string.Join(" ", array);
        Console.WriteLine(str);
   }

    indexMax = indexMax - 1;
    indexMin = 0;
    index2 = 1;
}

str = string.Join(" ", array);
Console.WriteLine("Отсортированный массив : " + str);