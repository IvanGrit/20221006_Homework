// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

using static System.Console;
Clear();
WriteLine("***Программа для подсчета количества положительных чисел, введенных пользователем***");
WriteLine("Введите числа, используя пробел или запятую в качестве разделителя");
string[] array = ReadLine()!.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
int x = countNumbers(array);
WriteLine($"Введено {x} положительных чисел");








int countNumbers(string[] array4)
{
    int numbers = 0;
    int[] array5 = new int[array4.Length];
    
    for (int i = 0; i < array4.Length; i++)
    {
        array5[i] = Convert.ToInt32(array4[i]);
    }
    
    for (int i = 0; i < array5.Length; i++)
    {
        if(array5[i] > 0) numbers++;
    }
    return numbers;
}