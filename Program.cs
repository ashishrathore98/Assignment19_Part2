using System;

namespace Assignment19
{
    delegate T Operation<T>(T a, T b);

    internal class GenericFunc
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Generic Delegate \n");
                Operation<int> add = Add;
                Operation<int> diff = Subtract;
                Operation<int> mul = Multiply;
                Operation<int> div = Divide;

                Console.WriteLine("Input 1st #: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Input 2nd #: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("\nSelect the choice of Operation to Perform\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit\n");

                while (true)
                {
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            {
                                int result = add(a, b);
                                Console.WriteLine($"\nSum: {result}");
                                break;
                            }
                        case 2:
                            {
                                int result = Subtract(a, b);
                                Console.WriteLine($"\nDifference: {result}");
                                break;
                            }
                        case 3:
                            {
                                int result = Multiply(a, b);
                                Console.WriteLine($"\nProduct: {result}");
                                break;
                            }
                        case 4:
                            {
                                int result = Divide(a, b);
                                Console.WriteLine($"\nDivision: {result}");
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("\nExiting the program.");
                                return; // Exit the Main method and terminate the program.
                            }
                        default:
                            {
                                Console.WriteLine("\nWrong Option....!!!!\nSelect the Right Option");
                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}