// Задача 41. Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

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

int PositiveNumbers(int[] arr)
{
    int pos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) pos++;
    }
    return pos;
}

Console.WriteLine("Введите любое количество отрицательных и положительных чисел через запятую: ");
string numbers = Console.ReadLine();

string[] Separation(string num)
{
    char[] spearator = {',', ' '};
    string[] strlist = num.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
    return strlist;
}

int[] ConVertation(string[] strlist)
{
int[] convertedarray = new int[strlist.Length];
for (int i = 0; i < strlist.Length; i++)
{
    convertedarray[i] = Convert.ToInt32(strlist[i]);
}
return convertedarray;
}

string[] StrNumbers = Separation(numbers);
int[] array1 = ConVertation(StrNumbers);
Separation(numbers);
Console.WriteLine($"Создаем массив из введенных чисел");
PrintArray(array1);
Console.WriteLine($"Положительных чисел -> {PositiveNumbers(array1)}");