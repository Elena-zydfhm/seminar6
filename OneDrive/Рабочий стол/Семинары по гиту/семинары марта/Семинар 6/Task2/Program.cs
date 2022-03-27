// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101         3  -> 11           2  -> 10
int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}
int a = Prompt("Введите десятичное число A => ");
int c=0; //остаток
int i = 0;
int [] b = new int [10]; 
while(a>=1)
{
c = a%2;
a = a/2;
b[i]=c;
i++;
//Console.Write(c); 
} 
//Console.WriteLine();
for(int j = i-1; j >= 0; j--)
Console.Write(b[j]);









