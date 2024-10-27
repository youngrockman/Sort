using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.BubbleSort
{
    internal class Bogosort1
    {
        static void Main()
        {
            
            Console.WriteLine("Введите элементы массива через пробел:");
            string input = Console.ReadLine();

            // Преобразуем строку ввода в массив целых чисел
            int[] array = input.Split(' ').Select(int.Parse).ToArray();

            //Сортировка
            Bogosort(array);

            
            Console.WriteLine("Отсортированный массив:");
            Console.WriteLine(string.Join(" ", array));
        }

        
        static void Bogosort(int[] array)
        {
            Random random = new Random();
            // Пока массив не отсортирован, перемешиваем элементы случайным образом
            while (!IsSorted(array))
            {
                Shuffle(array, random);
            }
        }

        
        static bool IsSorted(int[] array)
        {
            // Проверяем каждый элемент, чтобы убедиться, что он не больше следующего
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false; 
                }
            }
            return true; 
        }

        // Метод для перемешивания элементов массива случайным образом
        static void Shuffle(int[] array, Random random)
        {
            // Проходим по массиву с конца до начала, перемешивая элементы
            for (int i = array.Length - 1; i > 0; i--)
            {
                // Генерируем случайный индекс для обмена элементами
                int j = random.Next(i + 1);
                // Обмениваем элементы array[i] и array[j]
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}
