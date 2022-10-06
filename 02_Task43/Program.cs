// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

using static System.Console;
Clear();
WriteLine("*** Находим точки пересечения графиков уравнений y = k1*x + b1, y = k2*x + b2 ***");
WriteLine("Введите значения k1, b1, k2 и b2, используя пробел или запятую в качестве разделителя: ");
string[] array = ReadLine()!.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
double[] data = ReadString(array);
double x = (data[3] - data[1])/(data[0] - data[2]);
double y = data[0]*x + data[1];
WriteLine($"Местом пересечения графиков уравнений y = {data[0]}*x + {data[1]}, y = {data[2]}*x + {data[3]} является точка с координатами ({x}; {y})");







double [] ReadString(string[] input)
{
    double[] result = new double [input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        result[i] = Convert.ToInt32(input[i]);
    }
    return result;
}
