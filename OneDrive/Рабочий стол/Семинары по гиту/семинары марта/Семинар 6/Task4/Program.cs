// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] arr = RandArray(20);
PrintArray(arr);
int[] arr2 = RandArray(arr.Length);
for(int i = 0; i < arr.Length; i++)
{
arr2[i] = arr[i];
}
PrintArray(arr2);
void PrintArray(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + " ");
    }
    Console.WriteLine();   
}
int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next();
    }
    return answer;
}


