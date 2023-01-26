void Star(int H)
{   
    int L = (H - 1) * 2 + 1;
    for (int i = 0; i < H; i++)
    {
        for (int j = 1; j <= L; j++) // j = 0
        {
            int StartOfStars = H - i; // 5 - 0
            int EndOfStars = H + i;   // 5 + 0
            if (j >= StartOfStars && j <= EndOfStars)
            {   
                Console.Write("*");
            }
            else 
            {
                Console.Write("1");
            }
        }
        Console.WriteLine();
    }
}

void Main()
{
    Console.Clear();
    Console.Write("Введите высоту елки: ");
    int h = int.Parse(Console.ReadLine()!);
    Star(h);
}
Main();





