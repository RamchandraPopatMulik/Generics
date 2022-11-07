using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic1
{
    public class MaximumNumber <T> where T:IComparable
    {
        public T firstValue,secondValue,thirdValue,fourthValue;
      
        public MaximumNumber(T firstValue, T secondValue, T thirdValue ,T fourthValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
            this.fourthValue = fourthValue;
        }

        public static T MaximumstringegerNumber(T firstValue, T secondValue, T thirdValue,T fourthValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 && firstValue.CompareTo(fourthValue) > 0 ||
               firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 && firstValue.CompareTo(fourthValue) > 0 ||
               firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0 && firstValue.CompareTo(fourthValue) > 0  )
            {
                Console.WriteLine("Maximum Number is :" + firstValue);
            }

            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(fourthValue) >= 0||
               secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(fourthValue) > 0 ||
               secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0 && secondValue.CompareTo(fourthValue) > 0)
            {
                Console.WriteLine("Maximum Number is :" + secondValue);
            }

            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(fourthValue) >= 0 ||
               thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(fourthValue) > 0 ||
               thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0 && thirdValue.CompareTo(fourthValue) > 0)
            {
                Console.WriteLine("Maximum Number is :" + thirdValue);
            }

            if (fourthValue.CompareTo(firstValue) > 0 && fourthValue.CompareTo(secondValue) > 0 && fourthValue.CompareTo(thirdValue) >= 0||
               fourthValue.CompareTo(firstValue) >= 0 && fourthValue.CompareTo(secondValue) > 0 && fourthValue.CompareTo(thirdValue) > 0 ||
               fourthValue.CompareTo(firstValue) > 0 && fourthValue.CompareTo(secondValue) >= 0 && fourthValue.CompareTo(thirdValue) > 0)
            {
                Console.WriteLine("Maximum Number is :" + fourthValue);
            }

            return firstValue;
        }
        public T MaxMethod()
        {
            T max = MaximumNumber<T>.MaximumstringegerNumber(this.firstValue,this.secondValue,this.thirdValue,this.fourthValue);
            return max;
        }
    }
}
