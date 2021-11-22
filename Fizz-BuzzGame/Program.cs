// For each number from 1 to 1000 in order,
// * print "Fizz" for the ones divisible by 3 (& not 5)
// * print "Buzz" for the ones divisible by 5 (& not 3)
// * print "Fizz-Buzz" for the ones divisible by both 3 and 5
// // * print the number itself, for all the rest of the numbers

int i;

for (i = 1; i < 1000; i++)
{
    
    if( i % 3 == 0 && i % 5 ==0 ){
        Console.WriteLine(i + " Fizz-Buzz");
    }
    else if (i % 3 == 0 ){
        Console.WriteLine(i + " Fizz");    
    }
    else if(i % 5 == 0){
        Console.WriteLine(i + " Buzz");
    }    
}