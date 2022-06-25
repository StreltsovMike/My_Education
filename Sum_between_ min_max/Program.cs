int[] array = new int[] { 10, 30, 400, 20, 50, 70, 1 };
var str = string.Join(" ", array);

int size = 7, index = 0, sum = 0,
    indexMax = 0, indexMin = 0,
    max = array[index], min = array[index];

while (index < size)
{
    if (array[index] > max)
    {
        max = array[index];
        indexMax = index;
    }
    if (array[index] < min)
    {
        min = array[index];
        indexMin = index;
    }
    index++;
}

Console.WriteLine("Максимум :" + max);
Console.WriteLine("Минимум : " + min);
Console.WriteLine("Индекс максимума : " + indexMax);
Console.WriteLine("Индекс минимума : " + indexMin);

Console.WriteLine("Сумма значений между Экстремумами (включительно) : ");

if (indexMax > indexMin)
{
    while (indexMax >= indexMin)
    {
        sum = sum + array[indexMin];
        Console.Write(array[indexMin]);
         if(indexMax>indexMin)
        {
            Console.Write(" + ");
        }
        indexMin++;
        
    }
}
else if (indexMax < indexMin)
{
    while (indexMin >= indexMax)
    {
        sum = sum + array[indexMax];
        Console.Write(array[indexMax]);
        if(indexMin>indexMax)
        {
            Console.Write(" + ");
        }
        indexMax++;

    }
}

Console.Write(" =  " + sum);