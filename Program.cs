Console.Clear();
Console.WriteLine("Введите размер первой матрицы");
int m1 = int.Parse(Console.ReadLine()!);
int n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите размер второй матрицы");
int m2 = int.Parse(Console.ReadLine()!);
int n2 = int.Parse(Console.ReadLine()!);
if(n1 != m2){Console.WriteLine("Данные матрицы не возможно пермножить");}
else 
{
    int[,] arr1 = GetArray(m1, n1);
    int[,] arr2 = GetArray(m2, n2);
    PrintArray(arr1);
    Console.WriteLine();
    PrintArray(arr2);
    Console.WriteLine();
    int[,] arr3 = MultiplicationArr(arr1, arr2);
    PrintArray(arr3);
}
int[,] GetArray(int m, int n) 
{
     int[,] result = new int[m, n];
     for (int i = 0; i < m; i++)      
     {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }       
     }
     return result;
}
void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] MultiplicationArr(int[,] Array1, int[,] Array2)
{   
    int[,] masresult = new int[Array1.GetLength(0), Array2.GetLength(1)];
    for(int i = 0; i < Array1.GetLength(0); i++)
    {
        for(int j = 0; j < Array2.GetLength(1); j++)
        {
            int result = 0;
            for(int k = 0; k < Array1.GetLength(1); k++)
            {
                result = Array1[i, k] * Array2[k, j] + result;
            }
        masresult[i, j] = result;
        }
    }
    return masresult;    
}
