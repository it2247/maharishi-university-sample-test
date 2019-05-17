using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MumSimpleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // An array with an odd number of elements is said to be centered if all elements(except the middle one) are strictly greater than the value of the middle element. Note that only arrays with an odd number of elements have a middle element. Write a function that accepts an integer array and returns 1 if it is a centered array, otherwise it returns 0.
            Console.WriteLine("Centered Array :");
            Console.WriteLine(centered_array(new int[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(centered_array(new int[] { 3, 2, 1, 4, 5 }));
            Console.WriteLine(centered_array(new int[] { 3, 2, 1, 4, 1 }));
            Console.WriteLine(centered_array(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(centered_array(new int[] { }));
            Console.WriteLine(centered_array(new int[] { 10 }));
            // Write a function that takes an array of integers as an argument and returns a value based on the sums of the even and odd numbers in the array. Let X = the sum of the odd numbers in the array and let Y = the sum of the even numbers. The function should return X – Y
            Console.WriteLine("Middle is the minimum of Array :");
            Console.WriteLine(x_y(new int[] { 1 }));
            Console.WriteLine(x_y(new int[] { 1, 2 }));
            Console.WriteLine(x_y(new int[] { 1, 2, 3 }));
            Console.WriteLine(x_y(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(x_y(new int[] { 3, 3, 4, 4 }));
            Console.WriteLine(x_y(new int[] { 3, 2, 3, 4 }));
            Console.WriteLine(x_y(new int[] { 4, 1, 2, 3 }));
            Console.WriteLine(x_y(new int[] { 1, 1 }));
            Console.WriteLine(x_y(new int[] { }));
            // Write a function that accepts a character array, a zero-based start position and a length. It should return a character array containing containing lengthcharacters starting with the startcharacter of the input array. The function should do error checking on the start position and the length and return null if the either value is not legal.
            Console.WriteLine("Check errors of Array :");
            Console.WriteLine(error_check(new char[] {'a', 'b', 'c'}, 0, 4));
            Console.WriteLine(error_check(new char[] {'a', 'b', 'c'}, 0, 3));
            Console.WriteLine(error_check(new char[] {'a', 'b', 'c'}, 0, 2));
            Console.WriteLine(error_check(new char[] {'a', 'b', 'c'}, 0, 1));
            Console.WriteLine(error_check(new char[] {'a', 'b', 'c'}, 1, 3));
            Console.WriteLine(error_check(new char[] {'a', 'b', 'c'}, 1, 2));
            Console.WriteLine(error_check(new char[] {'a', 'b', 'c'}, 1, 1));
            Console.WriteLine(error_check(new char[] {'a', 'b', 'c'}, 2, 2));
            Console.WriteLine(error_check(new char[] {'a', 'b', 'c'}, 2, 1));
            Console.WriteLine(error_check(new char[] {'a', 'b', 'c'}, 3, 1));
            Console.WriteLine(error_check(new char[] {'a', 'b', 'c'}, 1, 0));
            Console.WriteLine(error_check(new char[] {'a', 'b', 'c'}, -1, 2));
            Console.WriteLine(error_check(new char[] {'a', 'b', 'c'}, -1, -2));
            Console.WriteLine(error_check(new char[] { }, 0, 1));


            //wait for key
            Console.ReadKey();
        }

        private static int centered_array(int[] a)
        {
            int a_count = a.Count();
            if (a_count % 2 >0)
            {
                int middle_index = a_count / 2;
                List<int> a2 = a.ToList();
                a2.RemoveAt(middle_index);
                if (a2.Count > 0)
                {
                    int min = a2.Min();
                    if (a[middle_index] < min)
                    {
                        return 1;
                    }
                }
                else
                {
                    return 1;
                }

            }
            return 0;
        }
        private static int x_y (int[] a)
        {
            int x =0 , y=0;
            foreach (int item in a)
            {
                if (item % 2 == 0)
                {
                    y += item;
                }
                else
                {
                    x += item;
                }
            }
            return x-y;
        }
        private static char[] error_check (char[] a, int start, int len)
        {

            if (len > 0 && start >= 0) 
            {
                int end_index = start + len - 1;
                char[] result = new char[len];
                int x = 0;
                for (int c= start; c < end_index; c++)
                {
                    result[x] = a[c];
                    x++;
                }
                return result;
            }
            return null;
           
           
        }
    }
}
