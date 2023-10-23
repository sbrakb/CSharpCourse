namespace Methods2
{
    internal class Program
    {
        /* Method Overloading */
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(5, 6));
            Console.WriteLine(Multiply(5, 6, 7));
        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Multiply(int x, int y, int z)
        {
            return x * y * z;
        }
    }

}


