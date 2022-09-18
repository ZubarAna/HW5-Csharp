/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
/*
void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

void EvenNumbersArray()
{
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(",", array) + "]");
int count = 0;
for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        count +=1;
    }    
Console.WriteLine("amount of even nembers is " + count);
}
EvenNumbersArray();
*/

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-20, 20);
}
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

void SummaryArray()
{
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(",", array) + "]");
int sum = 0;
for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        sum +=array[i];
    }    
Console.WriteLine("Summary is equal to " + sum);
}
SummaryArray();
*/

/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
}
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
void DiffBetweenMinAndMaxNumbersInArray()
{
    int[] array = new int[n];
    InputArray(array); 
    Console.WriteLine("[" + string.Join(",", array) + "]");
    int max_num = array[0];
    int min_num = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max_num)
        {
            max_num = array[i];
        }
    }    
    Console.WriteLine("Max number is " + max_num);
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min_num)
        {
            min_num = array[i];
        }
    }    
    Console.WriteLine("Min number is " + min_num);
    Console.WriteLine("Difference between min an max is equal to " + (max_num - min_num));
}

DiffBetweenMinAndMaxNumbersInArray();
