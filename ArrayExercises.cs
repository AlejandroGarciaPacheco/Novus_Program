using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class ArrayExercises
    {
        
        public double sumOnlyIntegersAndDoubles(object[] array)
        {
            double total = 0;

            foreach (var item in array)
            {
                
                if (item is double || item is int)
                {
                    double number = Convert.ToDouble(item);
                    total += number;

                }
            }
            return total;
        }

        public int AddEachDigit(int number)
        {
            int total = 0;
            while (number > 0)
            {
                int digit = number % 10;
                total += digit;
                number /= 10;
            }
            return total;
        }

        public bool palindromeCheck(string s)
        {
            int j = s.Length - 1;
            for (int i = 0; i < s.Length/2; i++) { 
                if (s[i].Equals(s[j])) {
                    j--;
                } else
                {
                    return false;
                }
            }
            return true;
        }

        public int[] reverseOrder(int[] array)
        {
            int i = 0; 
            int j = array.Length - 1;
            int tmp;
            while (i < j)
            {
                tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;
                i++;
                j--;
            }
            return array;
        }
    }

    


}
