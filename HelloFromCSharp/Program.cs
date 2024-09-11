// See https://aka.ms/new-console-template for more information
Console.WriteLine("Jumbo Rafiki!\nHello Everybody.\n");

Console.WriteLine("Ahmed is the 9th Raikage.\n");

Console.WriteLine("Please enter your name: ");

string? yourName = Console.ReadLine();

Console.WriteLine("Hello " +  yourName + ".");

/* 
 * Below is my first Console Basics 
 * from 2023 
 */

Console.WriteLine("Hello, Friend. I am King Ahmed.");

byte byteNumber = 2;
int countNumber = 10;
float totalPrice = 20.94f;
char character = 'A';
string firstNameOfKage = "Ahmed";
bool isWorking = false;

Console.WriteLine(byteNumber);
Console.WriteLine(countNumber);
Console.WriteLine(totalPrice);
Console.WriteLine(character);
Console.WriteLine(firstNameOfKage);
Console.WriteLine(isWorking);

Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

const float valueOfPi = 3.14f;
Console.WriteLine("value of Pi: " + valueOfPi);

// FibonacciExample
int n1 = 0, n2 = 1, n3, i, number;
Console.Write("Enter the number of elements: ");
number = int.Parse(Console.ReadLine());
Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
{
    n3 = n1 + n2;
    Console.Write(n3 + " ");
    n1 = n2;
    n2 = n3; 
}