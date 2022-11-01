using System;

int[] array = { 1, 15, 35, 7, 46, 0, 17, 44, 8 };
var count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 0 && array[i] <= 9)
    {
        count++;
    }
}
Console.WriteLine("{" + array + "}" + " arrayında " + count + " rəqəm var.");