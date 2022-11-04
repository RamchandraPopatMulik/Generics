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

           PrintArray<int>print= new PrintArray<int>(intArray);
           print.toPrint();
           PrintArray<double>print1= new PrintArray<double>(doubleArray);
           print1.toPrint();
           PrintArray<Char>print2=new PrintArray<char>(charArray);
           print2.toPrint();
        }
    }
}