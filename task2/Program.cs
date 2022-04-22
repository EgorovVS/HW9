/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N используя рекурсию. */

int M = Prompt("Введите число M ");
int N = Prompt("Введите число N");
PrintNaturalSum(M,N);

int Prompt(string message)
{
    Console.WriteLine(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

void PrintNaturalSum (int M, int N)
{   
    int sum = 0;
    if(M>N) return;
    if (M!=0)
    {
    sum = sum + M;
    }
    PrintNaturalSum(sum, M+1);
}