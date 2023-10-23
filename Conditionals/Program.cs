// if - else
var number = 11;

if (number == 10)
    Console.WriteLine("Number is 10");
else if (number == 20)
    Console.WriteLine("Number is 20");
else
    Console.WriteLine("Number is not 10 or 20");


// single - line
var number2 = 17;
Console.WriteLine(number2 == 10 ? "Number2 is 10" : "number2 is not 10");

// switch - case
int number3 = 15;
switch (number3)
{
    case 10:
        Console.WriteLine("Number3 is 10");
        break;
    case 20:
        Console.WriteLine("Number3 is 20");
        break;
    default:
        Console.WriteLine("Number3 is not 10 or 20");
        break;
}


// multiple condition
int number4 = -101;

if (number4 >= 0 && number4 <= 100)
    Console.WriteLine("Number4 is between 0-100");
else if (number4 > 100 && number4 <= 200)
    Console.WriteLine("bu sayı 0 -100 arasındadır");
else if (number4 > 200 || number4 < 0)
    Console.WriteLine("Number4 is negative or greater than 200");



// nested coditions
int number5 = 25;

if (number5 < 100)
{
    if (number5 >= 90 && number5 < 100)
    {
        if(number5 > 93)
        {

        }
        else if(number5 > 95)
        {

        }
    }
}






















