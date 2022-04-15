/* Задайте значения M и N. Напишите программу, которая выведет все чётные 
натуральные числа в промежутке от M до N используя рекурсию. */

int M = Prompt("Введите число M ");
int N = Prompt("Введите число N");
PrintEven(M,N);

int Prompt(string message)
{
    Console.WriteLine(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

void PrintEven (int M, int N)
{
    if(M>N) return;
    if (M % 2 == 0)
    Console.Write(M + " ");
    PrintEven(M+1, N);
}