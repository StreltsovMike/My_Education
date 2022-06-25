int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
var str = string.Join(" ", array);

Console.WriteLine("Изначальный массив : " + str);

int size = 6,
    indexMax = size,
    indexMin = 0,
    X;

while (indexMax > indexMin)
{
    X = array[indexMax] - array[indexMin];
    array[indexMax] = array[indexMax] - X;
    array[indexMin] = array[indexMin] + X;
    indexMax = indexMax - 1;
    indexMin++;
}
str = string.Join(" ", array);
Console.Write("Перевернутый массив : " + str);