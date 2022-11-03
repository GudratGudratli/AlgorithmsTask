using System;

void Task1()
{
    int i = 0;
    int small = 0, big = 0;
    int smallVal = 1, bigVal = 1;

    int[] arr = { 5, 8, 2, 15, 84 };
    small = arr[0];
    big = arr[0];

    for (i = 1; i < arr.Length; i++)
    {
        if (small > arr[i])
        {
            small = arr[i];
            ++smallVal;
        }

        if (big < arr[i])
        {
            big = arr[i];
            ++bigVal;
        }
    }
    smallVal = smallVal + bigVal;
    bigVal = smallVal - bigVal;
    smallVal = smallVal - bigVal;

    arr[smallVal] = small;
    arr[bigVal] = big;

    for (int j = 0; j < arr.Length; j++)
    {
        Console.WriteLine("Array elements: " + arr[j]);
    }

    Console.WriteLine();

    Console.WriteLine("Smallest element's index: " + smallVal);
    Console.WriteLine("Biggest element's index: " + bigVal);
    Console.WriteLine("New smallest element in array: " + small);
    Console.WriteLine("New Biggest element in array: " + big);

}

void Task2()
{
    int digit = 12922;
    int num = digit;

    int value = 0;
    int num0 = 0;
    int num1 = 0;
    int num2 = 0;
    int num3 = 0;
    int num4 = 0;
    int num5 = 0;
    int num6 = 0;
    int num7 = 0;
    int num8 = 0;
    int num9 = 0;

    while (num > 0)
    {
        value = num % 10;
        num = (num - value) / 10;
        switch (value)
        {
            case 0:
                num0++;
                break;
            case 1:
                num1++;
                break;
            case 2:
                num2++;
                break;
            case 3:
                num3++;
                break;
            case 4:
                num4++;
                break;
            case 5:
                num5++;
                break;
            case 6:
                num6++;
                break;
            case 7:
                num7++;
                break;
            case 8:
                num8++;
                break;
            case 9:
                num9++;
                break;
        }
    }

    if (num0 >= 2 || num1 >= 2 || num2 >= 2 || num3 >= 2 || num4 >= 2 || num5 >= 2 || num6 >= 2 || num7 >= 2 || num8 >= 2 || num9 >= 2)
    {
        Console.WriteLine(digit + " - təkrarlanmış rəqəm(lər) var.");
    }
    else
    {
        Console.WriteLine(digit + " - təkrarlanmış rəqəm(lər) yoxdur.");
    }
}
Task1();
Task2();