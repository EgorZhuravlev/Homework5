/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

bool isParsedX = int.TryParse(Console.ReadLine(), out int X);
if (!isParsedX)
{
    Console.WriteLine("Данные ввели некорректно");
}

int[] userArray = GenerateArray(X);
int result = Count(userArray);
PrintArray(userArray);
Console.WriteLine(result);


int Count (int[] userArray)
{
    int even = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i] % 2 == 0) 
        {
            even = even + 1;
        }
        
    }
    return even;
}

void PrintArray(int[] userArray)
{
    string message = string.Join(" ,", userArray);
    Console.WriteLine(message);
}

int[] GenerateArray(int X)
{
    Random random = new Random();
    int[] userArray = new int[X];
    for (int i = 0; i < userArray.Length; i++)
    {
        userArray[i] = random.Next(100, 1000);
    }
    return userArray;
}