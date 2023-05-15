using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class sorting
    {
        #region SelectionSort
        // Selection Sort for Integer type data
        static public void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)         // loop executed util the second last position
            {
                for (int j = i + 1; j < array.Length; j++)     // innner loop start from outer position + 1
                {
                    if (array[i] > array[j])                   // if first element is greater than next element do swapping
                    {
                        //swapping using xor
                        array[i] ^= array[j];
                        array[j] ^= array[i];
                        array[i] ^= array[j];
                    }
                }
            }
        }

        //Selection sort for String type data
        static public void SelectionSort(String[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)         // loop executed util the second last position
            {
                for (int j = i + 1; j < array.Length; j++)     // innner loop start from outer position + 1
                {
                    if (array[i].CompareTo(array[j]) > 0)                   // if first element is greater than next element do swapping
                    {
                        String temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        #endregion

        #region BubbleSort

        //Bubble Sort for Integer data type
        public static void bubbleSort(int[] array)
        {
            Boolean isChanged = false;
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i; j++)
                {
                    if (array[j] > array[j + 1])                // if first element is greater than next element do swapping
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        isChanged = true;                        // if changes required then update isChanged by true
                    }
                }
                if (isChanged == false)                            //if given array is already sorted then break the next iteration
                {
                    break;
                }
            }
        }

        //bubble sort for String data type
        public static void bubbleSort(String[] array)
        {
            Boolean isChanged = false;
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)                // if first element is greater than next element do swapping
                    {
                        String temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        isChanged = true;                                  // if changes required then update isChanged by true
                    }
                }
                if (isChanged == false)                                    //if given array is already sorted then break the next iteration
                {
                    break;
                }
            }
        }
        #endregion

        #region InsertionSort
        //Insertion sort for Integer data type 
        public static void insertionSort(int[] array)
        {
            int temp, i, j;
            for (i = 1; i < array.Length; i++)
            {
                temp = array[i];                                        // store first element which need to be compare
                for (j = i - 1; (j >= 0 && array[j] > temp); j--)
                {
                    array[j + 1] = array[j];
                }
                array[j + 1] = temp;
            }
        }

        //Insertion sort for String data type 
        public static void insertionSort(String[] array)
        {
            int i, j;
            String temp;
            for (i = 1; i < array.Length; i++)
            {
                temp = array[i];
                for (j = i - 1; (j >= 0 && array[j].CompareTo(temp) > 0); j--)
                {
                    array[j + 1] = array[j];
                }
                array[j + 1] = temp;
            }
        }
        #endregion

        #region MergeSort
        //Merge Sort for int type data
        public static void MergeSort(int[] array, int left, int right)
        {
            if (right == left)
                return;

            int mid = (left + right) / 2;

            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);

            int[] temp = new int[right - left + 1];
            int i = left, j = mid + 1, k = 0;
            while (i <= mid && j <= right)
            {
                if (array[i] < array[j])
                {
                    temp[k++] = array[i++];
                }
                else
                {
                    temp[k++] = array[j++];
                }
            }

            while (i <= mid)
            {
                temp[k++] = array[i++];
            }
            while (j <= right)
            {
                temp[k++] = array[j++];
            }

            for (k = 0; k < temp.Length; k++)
            {
                array[left + k] = temp[k];
            }

        }

        //Merge Sort for int type data
        public static void MergeSort(String[] array, int left, int right)
        {
            if (right == left)
                return;

            int mid = (left + right) / 2;

            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);

            String[] temp = new String[right - left + 1];
            int i = left, j = mid + 1, k = 0;
            while (i <= mid && j <= right)
            {
                if (array[i].CompareTo(array[j]) < 0)
                {
                    temp[k++] = array[i++];
                }
                else
                {
                    temp[k++] = array[j++];
                }
            }

            while (i <= mid)
            {
                temp[k++] = array[i++];
            }
            while (j <= right)
            {
                temp[k++] = array[j++];
            }

            for (k = 0; k < temp.Length; k++)
            {
                array[left + k] = temp[k];
            }

        }
        #endregion

        #region QuickSort
        //Quick sort for Int Type data
        public static void QuickSort(int[] array, int left, int right)
        {

            if (left >= right)
                return;
            int temp;
            int i = left;
            int j = right;
            while (i < j)
            {
                while (i <= right && array[i] <= array[left])
                {
                    i++;
                }
                while (array[j] > array[left])
                { j--; }
                if (i < j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            temp = array[left];
            array[left] = array[j];
            array[j] = temp;
            QuickSort(array, left, j - 1);
            QuickSort(array, j + 1, right);
        }

        //Quick sort for String Type data
        public static void QuickSort(String[] array, int left, int right)
        {
            if (left >= right)
                return;
            String temp;
            int i = left;
            int j = right;
            while (i < j)
            {
                while (i <= right && array[i].CompareTo(array[left]) <= 0)
                {
                    i++;
                }
                while ((array[j].CompareTo(array[left])) > 0)
                { j--; }

                if (i < j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            temp = array[left];
            array[left] = array[j];
            array[j] = temp;
            QuickSort(array, left, j - 1);
            QuickSort(array, j + 1, right);
        }
        #endregion
    }



    internal class Test
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of element in Array:");
            int noOfElements = System.Int32.Parse(Console.ReadLine());


            Console.WriteLine("Element are Integer or String? 0 for integer 1 for string :");
            int typeOfArray = System.Int32.Parse(Console.ReadLine());
            if (typeOfArray == 0)
            {
                int[] arr = new int[noOfElements];
                Console.WriteLine("Enter the element------> ");
                for (int i = 0; i < noOfElements; i++)
                {
                    arr[i] = System.Int32.Parse(Console.ReadLine());
                    //Console.ReadLine();
                }
                Console.WriteLine("Enter your choice of sort----- :");
                Console.WriteLine(string.Format("1.Selection Sort \n2.Bubble Sort \n3.Insertion Sort \n4.Merge Sort \n5.Quick Sort"));
                int typeOfSort = System.Int32.Parse(Console.ReadLine());
                switch (typeOfSort)
                {
                    case 1:
                        sorting.SelectionSort(arr);
                        break;
                    case 2:
                        sorting.bubbleSort(arr);
                        break;
                    case 3:
                        sorting.insertionSort(arr);
                        break;
                    case 4:
                        sorting.MergeSort(arr, 0, arr.Length - 1);
                        break;
                    case 5:
                        sorting.QuickSort(arr, 0, arr.Length - 1);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;

                }
                Array.ForEach(arr, (num) => { Console.Write(num + ", "); });
                Console.ReadLine();
            }
            else
            {
                string[] arr = new string[noOfElements];
                Console.WriteLine("Enter the element------------> ");
                for (int i = 0; i < noOfElements; i++)
                {
                    arr[i] = Console.ReadLine();
                }
                Console.WriteLine("Enter your choice of sort :");
                Console.WriteLine(string.Format("1.Selection Sort \n2.Bubble Sort \n3.Insertion Sort \n4.Merge Sort \n5.Quick Sort"));
                int typeOfSort = System.Int32.Parse(Console.ReadLine());
                switch (typeOfSort)
                {
                    case 1:
                        sorting.SelectionSort(arr);
                        break;
                    case 2:
                        sorting.bubbleSort(arr);
                        break;
                    case 3:
                        sorting.insertionSort(arr);
                        break;
                    case 4:
                        sorting.MergeSort(arr, 0, arr.Length - 1);
                        break;
                    case 5:
                        sorting.QuickSort(arr, 0, arr.Length - 1);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;

                }
                Array.ForEach(arr, (num) => { Console.Write(num + ", "); });
                Console.ReadLine();
            }
        }

    }
}