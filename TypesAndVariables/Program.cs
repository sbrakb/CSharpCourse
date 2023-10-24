/* Value Types *
 * 
 * 1) PredefinedTypes; byte, sbyte, short, unshort, int, uint, char, bool, float, doduble, decimal
 * 2) UserDefinedTypes; enum, struct
 * 
 */

byte number= 255;                      //   byte  - max ( 8 bit, 1 byte) 
short number1 = 32767;                 //   short - max (16 bit, 2 byte)
int number2 = 2147483647;              //     int - max (32 bit, 4 byte)
long number3 = 9223372036854775807;    //    long - max (64 bit, 8 byte)

double number4 = 15.4;                 //  double - after comma, 15-16 character   (64 bit, 8 byte)
decimal number5 = 10.4m;               // decimal - after comma, 25-26 character  (128 bit, 16 byte)
decimal number6 = 10m;                 // decimal - implicit conversion   

//The var keyword is converts the types based on given value

var number7 = 20;                      // number7 is int
number7 = 'A';                         // since we have previously given an int value now number7 is 65 (ASCI)

var number8 = 25m;                     // number8 is decimal
var number9 = 34d;                     // number9 is double
var number10 = "55";                   // number10 is string

bool condition = false;
char character = 'A';

Console.WriteLine("Byte Max         = {0} (0-255)", number);
Console.WriteLine("Short Max        = {0}", number1);
Console.WriteLine("Int Max          = {0}", number2);
Console.WriteLine("Long Max         = {0}", number3);
Console.WriteLine("Long             = {0}", number4);
Console.WriteLine("Decimal          = {0}", number5);
Console.WriteLine("Decimal-Implicit = {0}\n", number6);

Console.WriteLine("***** VAR KEYWORD *****");
Console.WriteLine($"Number 7 is int     : {number7}");
Console.WriteLine($"Number 8 is decimal : {number8}");
Console.WriteLine($"Number 9 is double  : {number9}");
Console.WriteLine($"Number 10 is string : {number10}\n");


Console.WriteLine("-----");
Console.WriteLine($"bool: {condition}");
Console.WriteLine($"character: {character} , ASCI: {(int)character}");
Console.WriteLine("-----\n");

Console.WriteLine("***** ENUMS *****");
Console.WriteLine(Days.Friday);          // Friday
Console.WriteLine((int)Days.Friday);     // 4  (index)
Console.WriteLine((int)Days2.Tuesday);   // 11
Console.WriteLine((int)Days2.Wednesday); // 35
Console.WriteLine((int)Days2.Thursday);  // 36


enum Days
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}

// Initial values can be changed in enumerations
// Values which is not changed automatically increase according to previous index
enum Days2
{
    Monday=10, Tuesday=15, Wednesday=35, Thursday, Friday, Saturday, Sunday
}
