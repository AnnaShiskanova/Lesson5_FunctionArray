Console.Clear();
Console.WriteLine("1 - Task 34");
Console.WriteLine("2 - Task 36");
Console.WriteLine("3 - Task 38");
int NumberOfTask = Prompt("Введите номер задачи");
switch(NumberOfTask)
{
    case 1:
    Console.Clear();
    Task34();
    break;

    case 2:
    Console.Clear();
    // Task36();
    break;

    case 3:
    Console.Clear();
    // Task38();
    break;

    default:
    Console.WriteLine("Номер задачи введен неверно");
    break;
    
}
    static int Prompt(string massage)//метод запроса числа
{
    Console.WriteLine(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void Task34()
{ //Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

    Console.WriteLine("Input lenght array");
    int lenght = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[lenght];//for exemple 10 elements
    
    int count = 0;

    int [] RandomNumbersArray()
    {   
        int [] arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
    return arr;

    }
   void CountEvenNumbers(int[] arr)
   {
    foreach (int el in array)
    {
        if (el % 2 ==0)
        {
    
            count ++;
        }

        

    }
   }
    
    void PrintResult(int[] arr, int count)
    {
    Console.WriteLine($"Array result is {String.Join(" ", array)}");//Join помогает вывести массив в читаемой форме через разделитель, здесь разделитель 
    Console.Write($" Number of even numbers {count}");
    
    }


    array = RandomNumbersArray();
    CountEvenNumbers(array);
    PrintResult(array, count);
}





