/* Loops */

// for
for (int i = 0; i <= 100; i += 2)
    Console.WriteLine(i);
Console.WriteLine("Finished!");

// while
int a = 100;
while (a != -2)
{
    Console.WriteLine(a);
    a -= 2;
}

// do - while
int b = 100;
do
{
    Console.WriteLine(b);
    b -= 5;
} while (b >= 0);

// forEach

string[] names = { "Engin", "Derin", "Salih" };

foreach (var name in names)
{
    // names[name] = "Ahmet";       // array elements cant be changed in forEach loop
    Console.Write(name + " ");
}

Console.WriteLine();

for (int i = 0; i < names.Length; i++)
{
    names[i] = "Ahmet";
    Console.WriteLine(names[i]);    // array elemennts can be changed in for loop
}


// Finding Prime Number
var isPrime = IsPrimeNumber(20);

if (!isPrime)
{
    Console.WriteLine("This number is not prime");
}
else
{
    Console.WriteLine("This number is prime");
}

static bool IsPrimeNumber(int n)
{
    bool result = true;
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            result = false;
            break;
        }
    }
    return result;
}

