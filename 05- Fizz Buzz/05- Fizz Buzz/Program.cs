namespace _05__Fizz_Buzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //Setting the range to 1, not to exceed 100, with an increment of +1.
                for (int value = 1; value <= 100; value++)
                //If a variable of 3 are printed, Fizz will take it's place
                if (value % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                //If a variable of 5 is printed, Buzz will take its place
                else if (value % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                //If variables of both 3 and 5 are printed, Fizz Buzz will take its place
                else if (value % 3 == 0 && value % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                //If none of the above rules are applied, only the interger will be printed
                else 
                {
                    Console.WriteLine(value);
                }

            
        }
    }
}
