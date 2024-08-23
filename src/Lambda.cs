 using System;
namespace Samples{
public class Lambda
{
delegate int a(int b, int c);
public static int Main(string[] args)
{
    Print(5, 5, (a, b) => a + b);
    Print(4, 2, (x, y) => x * y);
    Print(6, 6, (a, b) => a + b);
    Print(144, 666, (x, y) => x * y);
    return 0;
}

static void Print(int a, int b, a del)
{
    Console.WriteLine("Imprimiendo: {0}",del(a, b));
}
}
}
