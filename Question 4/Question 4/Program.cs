int i;
int indent = 3;
for (i = 1; i < 10000; i++)
{
    int x, rem, sum = 0;
    for (x = 1; x < i; x++)
    {
        rem = i % x;

        if (rem == 0)
        {
            sum = sum + x;
        }
    }

    string the = i + " si";

    if (sum == i)
    {
        Console.Write("".PadLeft(indent));
        Console.WriteLine(i + " is perfect");
        indent--;
    }
    sum = 0;
}