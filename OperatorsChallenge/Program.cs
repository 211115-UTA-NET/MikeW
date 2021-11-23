Console.WriteLine("### Increment ###");
for (int i = 0; i < 5; i++)
{
    if (i<5)
    {
        i++;
        Console.WriteLine(i);
    }
}

Console.WriteLine("### Decrement###");
int a = 5;
while (a>1)
{
     a--;
     Console.WriteLine(a);
}

Console.WriteLine("### Not Boolean ###");
bool b = true;
Console.WriteLine(!b);

Console.WriteLine("### Negate ###");
int c = 5;
Console.WriteLine(-c);

Console.WriteLine("### Sum ###");
int d = 3;
int e = 5;
Console.WriteLine(d+e);

Console.WriteLine("### Diff ###");
Console.WriteLine(e-d);

Console.WriteLine("### Product ###");
Console.WriteLine(d*e);

Console.WriteLine("### Quotient ###");
Console.WriteLine(e/d);

Console.WriteLine("### Remainder ###");
Console.WriteLine(e%d);

Console.WriteLine("### And ###");

int x = 6;
int y = 7;

if (x != 0 & x > y)
{
    Console.WriteLine("True");
}

Console.WriteLine("### OR ###");
if(x == y | x < 0)
{
    Console.WriteLine("true");
}