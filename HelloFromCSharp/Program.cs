// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n-- ================================================================================ -- \n");

Console.WriteLine("Jumbo Rafiki!\nHello Everybody.\n");

Console.WriteLine("\nAhmed is the 9th Raikage.\n");

Console.WriteLine("\nPlease enter your name: ");

string? yourName = Console.ReadLine();

Console.WriteLine("Hello " +  yourName + ".\n Pleased to make your acquaintance.");

Console.WriteLine("\n-- ================================================================================ -- \n");
Console.WriteLine("\n-- Console Basics 2023 for Ahmed O. Roberts -- \n");
Console.WriteLine("\n-- ================================================================================ -- \n");


// Below is my first Console Basics from 2023 

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

Console.WriteLine("\n-- ================================================================================ -- \n");
//Console.WriteLine("\n-- ================================================================================ -- \n");
/* 
 * Console.WriteLine("\n-- ================================================================================ -- \n");
 * 
 */

Console.WriteLine("\n-- ================================================================================ -- \n");
Console.WriteLine("\n-- Fibonaccis Section -- \n");

Console.WriteLine("Fibonacci Section {0} {1}", byte.MinValue, byte.MaxValue);

const float valueOfPi = 3.14f;
Console.WriteLine("\n Value of Pi: " + valueOfPi);

// FibonacciExample
int n1 = 0, n2 = 1, n3, i, fib_number, comparisonnumber = 9;
Console.Write("\nDo Fibonacci:\nEnter the number of elements: ");
fib_number = int.Parse(Console.ReadLine());
Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    

// I love a good ternary
string comparison01 = fib_number >= comparisonnumber ? "greater than or equal " : "less than ";
Console.WriteLine("So, your fib_number " + fib_number + " is " + comparison01 + comparisonnumber);

for (i = 2; i < fib_number; ++i) //loop starts from 2 because 0 and 1 are already printed    
{
    n3 = n1 + n2;
    Console.Write(n3 + " ");
    n1 = n2;
    n2 = n3; 
}

/*
 * now 2024.12.11 starting hard core C# Again
 * building an app for Crossroads Health
 */

// Value Types - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types

Console.WriteLine("\n -- Get down to your Basics \n");

int monthlyWage = 1234;
int months = 12, bonus = 1000;
bool isActive = false;
double rating = 99.25;
byte numberOfEmployees = 100; // Values between 0 and 255

// Type Safe - once a variable is declared it cannot chamge its type through out the execution

const decimal interestRate2024 = 0.07m;

// Strings in C#

string firstName = "Alexander";
string lastName = "Roberts";

// Expressions in C#

int aaa, bbb, ccc;
aaa = 9; bbb = 6; ccc = 3;
aaa++;
aaa += bbb;
ccc--;
double ddd = bbb + ccc;

double ratePerHour = 12.34d;
int numberOfHoursWorked = 165;

double currentMonthWage = ratePerHour * numberOfHoursWorked;

double monthBonus = 1000;

currentMonthWage += monthBonus;
Console.WriteLine(currentMonthWage);


// aliases for .NET type -- examples:
int a_int = 123;
System.Int32 b_int = 123;

var decimalLiteral = 42;
var hexLiteral = 0x2A;
var binaryLiteral = 0b_0010_1010;

byte a_byte = 17;
byte b_byte = 300;   // CS0031: Constant value '300' cannot be converted to a 'byte'

// use cast to convert
var signedByte = (sbyte)42;
var longVariable = (long)42;

// floating-point types
double a_double = 12.3;
System.Double b_double = 12.3;

double d_double = 3D;
d_double = 4d;
d_double = 3.934_001;

float f_float = 3_000.5F;
f_float = 5.4f;

decimal myMoney_decimal = 3_000.5m;
myMoney_decimal = 400.75M;