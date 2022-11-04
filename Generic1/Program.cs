namespace Generic1
{
   
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter First Value");
            string firstValue = Console.ReadLine();

            Console.WriteLine("Please Enter Second Value");
            string secondValue = Console.ReadLine();

            Console.WriteLine("Please Enter Third Value");
            string thirdValue = Console.ReadLine();

            MaximumNumber.MaximumstringegerNumber(firstValue, secondValue, thirdValue);
        }
    }
}