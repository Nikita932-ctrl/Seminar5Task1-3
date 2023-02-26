//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {

        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int[] gotArray = GetArray(3);
bool catchNumberInArray = false;
int count = 0;

for (int i = 0; i < gotArray.Length; i++)
{
    

    if (gotArray[i] % 2 == 0)
    {
        
        count++;
        catchNumberInArray = true;
    }
    

}

if (catchNumberInArray == true)
{
    Console.WriteLine($"В массиве {String.Join(", ", gotArray)} , {count} четных чисел");
}else
{
    Console.WriteLine($"В массиве {String.Join(", ", gotArray)} , четных чисел нет");
}


//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] GetArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {

        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int[] gotArray = GetArray(6);



int PrintGetArray()
{
    int sumOfGotArray = 0;

    for (int indexNotEvenNumber = 1; indexNotEvenNumber < gotArray.Length; indexNotEvenNumber += 2)
    {


        if (indexNotEvenNumber % 2 != 0)
        {
            sumOfGotArray += gotArray[indexNotEvenNumber];
        }
    }
    return sumOfGotArray;
}
Console.WriteLine($"[ {String.Join(", ", gotArray)} ]");
Console.WriteLine(PrintGetArray());

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GetRealNumberArray(int size)
{
    double[] array = new double[size];

    for (int i = 0; i < array.Length; i++)
    {

        array[i] = new Random().NextDouble() * 10;
    }
    return array;
}

double[] realNumber = GetRealNumberArray(4);

Console.WriteLine(String.Join(",", realNumber));


double MinValue = 0;


double FindMax()
{
    double MaxValue = 0;
    for (int i = 0; i < realNumber.Length; i++)
    {

        if (realNumber[i] > MaxValue)
        {
            MaxValue = realNumber[i];
        }


    }

    return MaxValue;
}


double FindMin()
{
    double MinValue = realNumber[0];
    for (int i = 1; i < realNumber.Length; i++)
    {

        if (realNumber[i] < MinValue)
        {
            MinValue = realNumber[i];
        }



    }

    return MinValue;
}


double FindBetween()
{
    double between = FindMax() - FindMin();

    return between;

}

Console.WriteLine(FindMax());
Console.WriteLine(FindMin());
Console.WriteLine(FindBetween());
