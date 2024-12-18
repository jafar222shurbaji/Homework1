using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            string binaryResult = DecimalToBinary(decimalNumber);
            Console.WriteLine($"The binary representation of {decimalNumber} is: {binaryResult}");

            ////////////////////////////////////////////////////////////////////////////////////

            int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17 };
            Console.Write("Enter the value to search for: ");
            int target = int.Parse(Console.ReadLine());

            int result = TernarySearch(sortedArray, 0, sortedArray.Length - 1, target);

            if (result != -1)
            {
                Console.WriteLine($"Value {target} found at index {result}.");
            }
            else
            {
                Console.WriteLine($"Value {target} not found in the array.");
            }
        }

        static string DecimalToBinary(int decimalNumber)
        {
            if (decimalNumber == 0) return "0";

            string binary = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                binary = remainder + binary;
                decimalNumber /= 2;
            }

            return binary;
        }

        ////////////////////////////////////////////////////////////////////////////////////////
        static int TernarySearch(int[] array, int left, int right, int target)
        {
            if (right >= left)
            {
                int mid1 = left + (right - left) / 3;
                int mid2 = right - (right - left) / 3;

                if (array[mid1] == target) return mid1;
                if (array[mid2] == target) return mid2;

                if (target < array[mid1])
                {
                    return TernarySearch(array, left, mid1 - 1, target);
                }
                else if (target > array[mid2])
                {
                    return TernarySearch(array, mid2 + 1, right, target);
                }
                else
                {
                    return TernarySearch(array, mid1 + 1, mid2 - 1, target);
                }
            }

            return -1;
        }
    }

}
