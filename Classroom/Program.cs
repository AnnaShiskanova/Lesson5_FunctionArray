Console.Clear();
Console.WriteLine("1 - Task 31");
Console.WriteLine("2 - Task 32");
Console.WriteLine("3 - Task 33");
int NumberOfTask = Prompt("Введите номер задачи");
switch(NumberOfTask)
{
    case 1:
    Console.Clear();
    Task31();
    break;

    case 2:
    Console.Clear();
    Task32();
    break;

    case 3:
    Console.Clear();
    Task33();
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



static void Task31()
{
    //Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
    // Найдите сумму отрицательных и положительных элементов массива.
    //Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
    //сумма отрицательных равна -20.

    int negative = 0, positive = 0;
    int[] arrayResult = new int[12];
    int[] GetArray()
    {
    int[] array = new int[12]; //12 elements in massive array
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10);//закладываем рандомные значения элементов в массив
    return array;
    }

    void SumArray(int[] array)
    {
    foreach (int el in array) //цикл сам перебирает каждый элемент массива, нам не нужно вносить условия как в for
    {
    if (el > 0)
    positive += el;
    else negative += el;
    }
    Console.WriteLine(negative + " " + positive);
    }

    void PrintResult(int[] array, int positive, int negative)
    {
    Console.WriteLine($"Array result is {String.Join("|", array)}");//Join помогает вывести массив в читаемой форме через разделитель, здесь разделитель 
    Console.WriteLine($"Positive sum is {positive} and Negative sum is {negative}");
    }

    arrayResult = GetArray();
    SumArray(arrayResult);
    PrintResult(arrayResult, positive, negative);
}


static void Task32()
{
//     // напишите программу замены элементов массива: положительные элементы замените на отрицательные и наоборот

    int[] array = new int[8];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10,11);
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
        Console.Write($"{array[i]}\t");
    }
}


static void Task33()
{
    //Задача 33: Задайте массив. Напишите программу, которая определяет, 
    //присутствует ли заданное число в массиве.
    //4; массив [6, 7, 19, 345, 3] -> нет
    //-3; массив [6, 7, 19, 345, -3] -> да
    

    
        int[] array = new int[8];
        Random random = new Random();
        
       
       

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10,11);
            Console.Write($"{array[i]}\t");
        }

        int a = GetNumber();

    

        int GetNumber()
        {
            Console.Write("Input number ");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
            
        }
        

        static bool TrueFalse(int[] array, int a)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == a)
                return true;
            }
            return false;
            
         

        }
        if (TrueFalse(array, a))
        {
            System.Console.WriteLine($"Number {a} is found");

        }
        else
        {
            System.Console.WriteLine("Number is not found");

        }
        
            
       




}