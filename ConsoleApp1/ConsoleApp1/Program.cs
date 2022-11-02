using System;


void Task2()
{
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
}

void Task1()
{
    int i = 0;
    int small = 0;
    int[] arr = { 5, 8, 2, 15, 84 };

    small = arr[0];

    for (i = 1; i < arr.Length; i++)
    {

        if (small > arr[i])
            small = arr[i];
    }

    Console.WriteLine("Smallest element in array: " + small);

}
Task1();