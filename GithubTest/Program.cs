// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int counter = 5;
CountBackwards(counter);

void CountBackwards(int n)
{
    if (n < 0)
    {
        Console.WriteLine("Done!");
        return;
    }
    Console.WriteLine(n);
    CountBackwards(n - 1);
}