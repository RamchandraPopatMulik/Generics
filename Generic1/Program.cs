namespace Generic1
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter First Value");
            int firstValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Second Value");
            int secondValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Third Value");
            int thirdValue = Convert.ToInt32(Console.ReadLine());

            MaximumNumber.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
        }
    }
}