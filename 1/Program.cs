int [] array = new int[5];
// void FullArray (int [] Array)
// {
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Console.WriteLine("Введите числa через запятую: ");
//         int.TryParse(Console.ReadLine(), out Array[i]);
//     }
// }

void PrintArray(int[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int PositivNumber(int[] arr)
{
    int pos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) pos++;
    }
    return pos;
}

void NumberString(string[] array)
{
    string[] strings = new string[] {};

    Console.WriteLine("Введите числa через запятую: ");
    int[] str = Array.ConvertAll(strings, int.Parse);
    Console.WriteLine(String.Join(",", str));
} 
   
PrintArray(array);
PositivNumber(array);
int positivNumber = PositivNumber(array);
NumberString(array);
Console.WriteLine($"Положительных чисел -> {positivNumber}");