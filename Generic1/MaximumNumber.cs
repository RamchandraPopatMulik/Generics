using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic1
{
    public class MaximumNumber <T> where T:IComparable
    {
        public T firstValue,secondValue,thirdValue;
      
        public MaximumNumber(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }

        public static T MaximumstringegerNumber(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
               firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
               firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                Console.WriteLine("Maximum Number is :" + firstValue);
            }

            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(firstValue) > 0 ||
               secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(firstValue) > 0 ||
               secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(firstValue) >= 0)
            {
                Console.WriteLine("Maximum Number is :" + secondValue);
            }

            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(firstValue) > 0 ||
               thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(firstValue) > 0 ||
               thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(firstValue) >= 0)
            {
                Console.WriteLine("Maximum Number is :" + thirdValue);
            }

            return firstValue;
        }
        public T MaxMethod()
        {
            T max = MaximumNumber<T>.MaximumstringegerNumber(this.firstValue,this.secondValue,this.thirdValue);
            return max;
        }
    }
}
