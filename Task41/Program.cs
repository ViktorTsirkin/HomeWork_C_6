/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2   -> 2
1, -7, 567, 89, 223   -> 4
*/


Console.Clear();
Console.Write("Введите количество элементов массива:\t");
int n = int.Parse(Console.ReadLine()!);

int[] array = GetArray(n); 
Console.WriteLine($"\nВывод массива: [{String.Join("; ", array)}]"); 

int GetQuant = GetQuantity(array);
Console.WriteLine($"\nКоличество чисел больше нуля составляет {GetQuant}");


int [] GetArray(int size) 
{
    int[] res = new int[size]; 
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите число-элемент массива {i}:\t");
        res[i] = int.Parse(Console.ReadLine()!); 
    }
    return res;
}


int GetQuantity(int[] array)
{
    int quan = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            quan++;
        }
    }
    return quan;
}

