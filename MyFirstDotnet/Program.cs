// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Mike!");




//casting
Console.WriteLine("#####Casting Example#####");
string start = "Begin";
object z = start;
string end = (string)z;
Console.WriteLine("starting string: " + start);
Console.WriteLine("ending string " +end);


//Conversion
Console.WriteLine("#####Conversion Example#####");
double a = 5.5;
byte b = (byte) a;
Console.WriteLine("The value of a is: " + a);
Console.WriteLine("The value of b is: " + b);

int ret = 78765432%256; //modulus
Console.WriteLine(ret);

//Parsing

Console.WriteLine("#####Parsing Example#####");
bool res;
int parsedstring;
string newString = "578";
res = int.TryParse(newString, out parsedstring);
Console.WriteLine("String could be parsed: " + res);

if (res is true){
    parsedstring = int.Parse(newString);
Console.WriteLine("The value of parsedString is: " + parsedstring);
} else {
    Console.WriteLine("The value of the newString could not be parsed.");
}

