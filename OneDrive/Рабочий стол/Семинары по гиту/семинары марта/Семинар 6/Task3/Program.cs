//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3     Если N = 3 -> 0 1 1             Если N = 7 -> 0 1 1 2 3 5 8
int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}
int n = Prompt("Введите число n => ");
//Value(n = n[i-2]+n[i-1]);
int n1=0; 
int n2=1; 
int n3;
int i=0;
 Console.Write(n1 +" "+n2+" " );
while(i<n-2)
{
n3 = n1+n2;
n1 = n2; 
n2 = n3;
i++;
Console.Write(n2+" " );
}
