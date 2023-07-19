using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfTwoArrays
{
    public class Program
    {
        static int[] FindIntersection(int[] array1, int[] array2)
        {
            List<int> intersection = new List<int>();

            foreach (int num1 in array1)
            {
                foreach (int num2 in array2)
                {
                    if (num1 == num2 && !intersection.Contains(num1))
                    {
                        intersection.Add(num1);
                        break;
                    }
                }
            }

            return intersection.ToArray();
        }

        static void Main()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 4, 5, 6, 7, 8 };

            int[] intersection = FindIntersection(array1, array2);

            Console.WriteLine("Intersection of the arrays:");
            foreach (int num in intersection)
            {
                Console.Write(num + " ");
            }
        }
    }
}
