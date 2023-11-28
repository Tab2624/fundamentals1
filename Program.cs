// #1
for (int i = 1; i<256; i++ )
{
    Console.WriteLine(i);
}

// #2
Random rand = new Random();
int idx = 0;
int sum = 0;
while ( idx < 5)
{
    int ranNum = rand.Next(10,20);
    sum+= ranNum;
    Console.WriteLine(ranNum);
    idx++;
}
Console.WriteLine($"the Sum is {sum}");

// #3
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 || i % 5 == 0 && !(i % 3 == 0 && i % 5 == 0))
    {
        Console.WriteLine(i);
        if(i % 3 ==0)
        {
            Console.WriteLine("FIZZ");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("BUZZ");
        }
    }
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FIZZBUZZ");
    }
    
}

