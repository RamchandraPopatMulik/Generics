namespace Generic1
{
   
    public class Program
    {
        static void Main(string[] args)
        {
            int [ ] arr = {112,344,432,555,678};

            MaximumNumber <int> maximumNumber = new MaximumNumber<int>(arr);
            maximumNumber.PrintMaxValue();
        }
    }
}