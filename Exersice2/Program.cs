// Напишите цикл, который принимает на вход два числа (А и В) 
// и возводит число А в натуральную степень В
int GetStep(int a, int b)
{
    int C = a;
    int count = 1;
    while (count < b)
    {
        a = a * C;
        count++;
    }
    return a;
}
void Main()
{
    Console.Clear();
    Console.Write("Enter number A: ");
    int A = int.Parse(Console.ReadLine()!);
    Console.Write("Enter number B: ");
    int B = int.Parse(Console.ReadLine()!);
    int answer = GetStep(A, B);
    Console.WriteLine(answer);
}
Main();
