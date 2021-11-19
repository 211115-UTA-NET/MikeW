string testString = "abcdefgh";Console.WriteLine(testString);


//read individual characters
Console.WriteLine("##### Individual Character ######");
char myChar = testString[0]; //turned string in to an array and are able to call specific positions
Console.WriteLine(myChar);


//find the length of a string of characters
Console.WriteLine("##### length #####");
Console.WriteLine(testString.Length);





//concatenation: noun , series of interconnected things or events
//line up/join multiple strings one after anouther
string one = "this is a string";
string two = "this is another string";
Console.WriteLine(one + " " + two);
Console.WriteLine(one);
Console.WriteLine(two);

//change cases to upper and lower case
Console.WriteLine("##### change cases #####");
testString = testString.ToUpper();
Console.WriteLine(testString);
testString = testString.ToLower();
Console.WriteLine(testString);


//change case of a specific letter to upper or to lower case


//trim end, trim start, trim
Console.WriteLine("##### Trim #####");
string badSpacing = "               hello             world                 ";
Console.WriteLine("start" + badSpacing + "end");
Console.WriteLine("start" + badSpacing.TrimStart() + "end");
Console.WriteLine("start" + badSpacing.TrimEnd() + "end");
Console.WriteLine("start" + badSpacing.Trim() + "end");


//break down a string into component characteristics
Console.WriteLine("##### Substrings #####");
string betterSpacing = "hello world";

Console.WriteLine( betterSpacing.Substring(6));


//compare the contents of a string

