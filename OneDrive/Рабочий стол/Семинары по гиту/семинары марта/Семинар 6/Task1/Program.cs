//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}
int a = Prompt("Введите число A => ");
int b = Prompt("Введите число В => ");
int c = Prompt("Введите число С => ");
if(a+b > c && a+c > b && b+c > a)
Console.WriteLine("Треугольник существует" );
else Console.WriteLine("Треугольник не существует" );