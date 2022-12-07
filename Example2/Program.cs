/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных индексах.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
 */

bool isParsedX = int.TryParse(Console.ReadLine(), out int X);
if (!isParsedX)
{
    Console.WriteLine("Данные ввели некорректно");
}

int[] userArray = GenerateArray(X);
int result = SumUnevenPosition(userArray);
PrintArray(userArray);
Console.WriteLine(result);


int SumUnevenPosition (int[] userArray)
{
    int sum = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
    if(i % 2 > 0)
    {
        sum = sum + userArray[i];
    }
    }
    return sum;
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
        userArray[i] = random.Next(-10, 10);
    }
    return userArray;
}