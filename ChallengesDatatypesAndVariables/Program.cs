// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

byte a = 128;
Console.WriteLine("A byte can equal: " + a);
int b = 12345;
Console.WriteLine("My int equals: " + b);
char  c = 'a';
Console.WriteLine("My favorite char is: " + c);
short d = 12345;
Console.WriteLine("Short: " +d);
float e = 86.56f;
Console.WriteLine("Float: " + e);
bool res = true;
Console.WriteLine("This boolean is: " + res);
double g = 3.14;
Console.WriteLine("Pi is a double: " + g);
long h = 789456123;
Console.WriteLine("A long: " + h);
string firstString = "I control Text";
Console.WriteLine(firstString);
string secondString = "456";


int parsedString;
res = int.TryParse(secondString, out parsedString);
Console.WriteLine("secondString as an integer: " + res);

if (res is true){
    parsedString = int.Parse(secondString);
Console.WriteLine("The value of parsedString is: " + parsedString);
} else {
    Console.WriteLine("The value of the newString could not be parsed.");
}