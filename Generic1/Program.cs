namespace Generic1
{
    public class PrintArray<T>
    {
        private  T[] inputArray;

        public PrintArray(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void toPrint()
        {
            foreach (T item in inputArray)
            {
                Console.WriteLine(item);
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 2.1, 2.2, 2.3, 2.4, 2.5, 2.6 };
            char[] charArray = { 'a', 'b', 'c', 'd', 'e' };

            new PrintArray<int>(intArray).toPrint();
            new PrintArray<double>(doubleArray).toPrint();
            new PrintArray<char>(charArray).toPrint();
        }
    }
}