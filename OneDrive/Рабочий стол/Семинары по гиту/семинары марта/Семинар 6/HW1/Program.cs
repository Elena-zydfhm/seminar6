// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] a = new int[10];
Console.WriteLine("Введите числа: =>  ");
int summ=0; 
for (int i = 0; i < a.Length; i++) 
{
    if (Int32.TryParse(Console.ReadLine(), out a[i]) != true) 
    {
        Console.Write("Enter correct naumber");
    }
    else 
    {
        if (a[i] > 0)
        {
           summ++;
        }
    }
}
Console.WriteLine($"Количество положительных чисел, введённых пользователем {summ}");
