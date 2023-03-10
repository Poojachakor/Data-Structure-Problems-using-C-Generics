namespace DataStructureProblemUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics programming");
            Console.WriteLine("------------------------------------");
            int[] intArray = { 20, 30, 40 };
            double[] doubleArray = { 12.7, 56.8, 89.2 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            string[] stringArray = { "HOW", "ARE", "YOU" };

            Console.WriteLine("Please choose option of program to execute");
            Console.WriteLine("1:PrintArray \n2: PrintArrayUsingGenericMethod");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    PrintArray.ToPrint(intArray);
                    PrintArray.ToPrint(doubleArray);
                    PrintArray.ToPrint(charArray);
                    Console.ReadLine();
                    break;
                case 2:
                    GenericsPrintArray.ToPrint<int>(intArray);
                    GenericsPrintArray.ToPrint<double>(doubleArray);
                    GenericsPrintArray.ToPrint<char>(charArray);
                    GenericsPrintArray.ToPrint<string>(stringArray);
                    break;
                default:
                    Console.WriteLine("Choose the correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
        