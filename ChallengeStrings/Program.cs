string one;
int two;
string three;

Console.WriteLine("Please enter your message and press enter");
string input = Console.ReadLine();
one = input;


Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter");
three= Console.ReadLine();
two = int.Parse(three);
Console.WriteLine("String three as an integer: " + three);

char myChar;
Console.WriteLine("For which character should I search in your original message?");
string four;
four = Console.ReadLine();
//string.IndexOf(myChar);
Console.WriteLine(four);

string firstName;
Console.WriteLine("What is your name?");
firstName = Console.ReadLine();

string lastName;
Console.WriteLine("What is your last name?");
lastName = Console.ReadLine();

Console.WriteLine(firstName + " " + lastName);