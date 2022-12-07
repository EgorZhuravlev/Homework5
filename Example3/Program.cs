/*  Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

int size = new Random().Next(1, 10);


double[] userArray = GenerateArray(size);
double result = DiffMinMax (userArray);
PrintArray(userArray);

Console.WriteLine(result);


double DiffMinMax (double[] userArray)
{
    double difference = Math.Round(userArray.Max() - userArray.Min(), 2);
    return difference;
}


void PrintArray(double[] userArray)
{
    string message = string.Join(", ", userArray);
    Console.WriteLine(message);
}

double[] GenerateArray(int size)
{
    double[] userArray = new double[size];
    for (int i = 0; i < userArray.Length; i++)
    {
        userArray[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
    return userArray;
}