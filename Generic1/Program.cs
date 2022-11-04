namespace Generic1
{
    internal class Program
    {
        public static void toPrint(int [] inputArray)
        {
            foreach (int item in inputArray)
            {
                Console.WriteLine(item);
            }

        }
        public static void toPrint(double[] inputArray)
        {
            foreach (double item in inputArray)
            {
                Console.WriteLine(item);
            }

        }
        public static void toPrint(char[] inputArray)
        {
            foreach (int item in inputArray)
            {
                Console.WriteLine(item);
            }

        }
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 2.1, 2.2, 2.3, 2.4, 2.5, 2.6 };
            char[] charArray = { 'a', 'b', 'c', 'd', 'e' };
            Program.toPrint(intArray);
            Program.toPrint(doubleArray);
            Program.toPrint(charArray);
        }
    }
}