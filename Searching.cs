using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
//Searching Program modified by Abhishek
namespace Searching
{

    public class Search
    {
        public static int LinearSearch(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                    return i;
            }
            return -1;
        }

        public static int LinearSearch(String[] arr, String key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(key))
                    return i;
            }
            return -1;
        }

        public static int BinarySearch(int[] arr, int key)
        {
            int left = 0, right = arr.Length - 1;
            int mid = (left + right) / 2;

            while (left < right)
            {
                if (arr[mid] == key)
                    return mid;
                else if (key < arr[mid])
                    right = mid;
                else
                    left = mid + 1;
            }

            return -1;
        }

        public static int BinarySearch(String[] arr, String key)
        {
            int left = 0, right = arr.Length - 1;
            int mid = (left + right) / 2;

            while (left < right)
            {
                if (arr[mid].Equals(key))
                    return mid;
                else if (key.CompareTo(arr[mid]) < 0)
                    right = mid;
                else
                    left = mid + 1;
            }

            return -1;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = -1;
            Console.WriteLine("Enter the number of element in Array:");
            int noOfElements = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Element are Integer or String? 0 for integer 1 for string :");
            int typeOfArray = System.Int32.Parse(Console.ReadLine());
            if (typeOfArray == 0)
            {
                int[] arr = new int[noOfElements];
                Console.WriteLine("Enter the element ");
                for (int i = 0; i < noOfElements; i++)
                {
                    arr[i] = System.Int32.Parse(Console.ReadLine());
                    //Console.ReadLine();
                }
                Console.WriteLine("Please eneter Key which is to be search:=");
                int key = System.Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter your choice of search :");
                Console.WriteLine(string.Format("1.Linear Search \n2.Binary Search"));
                int typeOfSearch = System.Int32.Parse(Console.ReadLine());
                switch (typeOfSearch)
                {
                    case 1:
                        result = Search.LinearSearch(arr, key);
                        break;
                    case 2:
                        result = Search.BinarySearch(arr, key);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;

                }
                if (result != -1)
                    Console.WriteLine("Key found at index= " + result);
                else
                    Console.WriteLine("Key does not exist");
            }
            else
            {
                string[] arr = new string[noOfElements];
                Console.WriteLine("Enter the element ");
                for (int i = 0; i < noOfElements; i++)
                {
                    arr[i] = Console.ReadLine();
                }
                Console.WriteLine("Please eneter Key which is to be search:=");
                String key= Console.ReadLine();
                Console.WriteLine("Enter your choice of search :");
                Console.WriteLine(string.Format("1.Linear Search \n2.Binary Search"));
                int typeOfSearch = System.Int32.Parse(Console.ReadLine());
                switch (typeOfSearch)
                {
                    case 1:
                        result = Search.LinearSearch(arr, key);
                        break;
                    case 2:
                        result = Search.BinarySearch(arr, key);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;

                }
                if (result != -1)
                    Console.WriteLine("Key found at index= " + result);
                else
                    Console.WriteLine("Key does not exist");
            }

            Console.ReadLine();

        }
    }
}
