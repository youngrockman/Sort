using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.MergeSort
{
    internal class MergeSort1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите длину массива");
            int masslength = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[masslength];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }


            mass = MergeSort(mass);


            Console.WriteLine("Отсортированный массив");
            foreach (int i in mass)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// MergeSort разделяет массив примерно пополам и вызывает сам себя, с двумя половинами, так же вызывает Merge
        /// </summary>
        /// <param name="mass">Входной массив для раздлеления</param>
        /// <returns></returns>
        static int[] MergeSort(int[] mass)
        {

            if (mass.Length <= 1)
            {
                return mass;
            }

            int mid = mass.Length / 2;
            int[] left = [.. mass.Take(mid)];
            int[] right = [.. mass.Skip(mid)];


            left = MergeSort(left);
            right = MergeSort(right);


            return Merge(left, right);
        }
        /// <summary>
        ///  Merge создает массив result в котором, в который будем помещать элементы массивов left и right по возростанию 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int index = 0, indexL = 0, indexR = 0;

            //Поскольку массивы left и right могут быть разного размера, мы будем записывать значения в result, пока не дойдем до конца хотя бы одного из них:
            while (indexL < left.Length && indexR < right.Length)
            {
                result[index++] = left[indexL] < right[indexR] ? left[indexL++] : right[indexR++];
            }
            //Если в цикле выше мы дошли до конца одного массива, но не дошли до конца второго, то оставшиеся элементы также потребуется добавить к результирующему массиву
            while (index < result.Length)
            {
                result[index++] = indexL != left.Length ? left[indexL++] : right[indexR];
            }

            return result;
        }
    }
}

