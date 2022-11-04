namespace Generic1
{
   
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter First Value");
            float firstValue = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please Enter Second Value");
            float secondValue = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please Enter Third Value");
            float thirdValue = Convert.ToSingle(Console.ReadLine());

            MaximumNumber.MaximumfloategerNumber(firstValue, secondValue, thirdValue);
        }
    }
}