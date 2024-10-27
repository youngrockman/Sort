using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Bogosort
{
    internal class BubbleSort1
    {
        //Сортировка пузырьком
        static void BubbleSort(IComparable[] array)
        {
            int i = array.Length - 1;
            while (i > 0)
            {
                int swap = 0;
                for (int j = 0; j < i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        IComparable temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swap = j;
                    }
                }
                i = swap;
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine()); ;
            }
            Console.WriteLine("Введённые элементы массива:");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            // Приведение массива int[] к IComparable[]
            IComparable[] comparableArray = array.Cast<IComparable>().ToArray();

            // Сортировка массива
            BubbleSort(comparableArray);

            
            Console.WriteLine("Отсортированные элементы массива:");
            foreach (int item in comparableArray)
            {
                Console.WriteLine(item);
            }
        }
    }
        
}

