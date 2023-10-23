// void methods
Add();

static void Add()
{
    Console.WriteLine("Added!");
}


// methods with parameters and return values
var result = Sum(5, 4);    // 9
Console.WriteLine(result);

static int Sum(int x, int y)
{
    var result = x + y;
    return result;
}

/*default parameters*
 - we can use more than one default parameters
 - default parameters must be at the end
*/
var result2 = Sum2(5);
Console.WriteLine(result2);   // 75
static int Sum2(int x, int y = 30, int z = 40)
{
    var result = x + y + z;
    return result;
}

// *** working with ref keyword ***

int number1 = 20;
int number2 = 100;
var result3 = Add2(number1, number2);
Console.WriteLine(result3);  // 130
Console.WriteLine(number1);  // 20
static int Add2(int x, int y)
{
    x = 30;
    return x + y;
}

// if we want to change number1's value in our method we should use ref keyword
// ref keyword is allow us to use value types as reference types 

int number4 = 20;  // we should set this value  (cant use like this - int number4;  )  its a must
int number5 = 100;
var result4 = Add3(ref number4, number5);
Console.WriteLine(result4);  // 130
Console.WriteLine(number4);  // 30
static int Add3(ref int x, int y)
{
    x = 30;  // when we use ref we dont need to set this value 
    return x + y;
}

// *** out keyword ***
// same logic as ref (allow us the use value types like reference types)
// difference is we dont need to set the value

int number6;    // no need to set the value (can be use like this - int number6; )  its not a must
int number7 = 100;
var result5 = Add4(out number6, number7);
Console.WriteLine(result5);  // 130
Console.WriteLine(number6);  // 30
static int Add4(out int x, int y)
{
    x = 30;  // to set this value also a must while we use out
    return x + y;
}


/* Method Overloading *
 * 
 * method overloading is not supported in top-level statements
 * 
static class MyClass
{
    static int Multiply(int x, int y)
    {
        return x * y;
    }
    static int Multiply(int x, int y, int z)
    {
        return x * y * z;
    }
}
*/



// Params
// allow us to use many parameters as we want

Console.WriteLine(Add5(2, 3));                      // 5
Console.WriteLine(Add5(2, 3, 4));                   // 9
Console.WriteLine(Add5(2, 3, 4, 5, 10, 25));        // 49


static int Add5(params int[] numbers)
{
    return numbers.Sum();
}


Console.WriteLine(Add6(2, 3, 4));              // 7
static int Add6(int x, params int[] numbers)   // params must be at the end
{
    return numbers.Sum();
}




