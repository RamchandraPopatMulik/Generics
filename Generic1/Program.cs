namespace Generic1
{
    internal class Program
    {
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (T item in inputArray)
            {
                Console.WriteLine(item);
            }

        }
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 2.1, 2.2, 2.3, 2.4, 2.5, 2.6 };
            char[] charArray = { 'a', 'b', 'c', 'd', 'e' };
            Program.toPrint<int>(intArray);
            Program.toPrint<double>(doubleArray);
            Program.toPrint<char>(charArray);
        }
    }
}