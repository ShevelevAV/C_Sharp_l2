int N = 1;
while (N < 101)
{
    if (N % 3 == 0 & N % 5 == 0)
    {

        Console.WriteLine("FizzBuzz");
        N++;

    }
    if (N % 3 == 0)
    {

        Console.WriteLine("Fizz");
        N++;

    }
    if (N % 5 == 0)
    {

        Console.WriteLine("Buzz");
        N++;
    }
    else
    {
        Console.WriteLine(N);
        N++;
    }
}
