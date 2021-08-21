using System;

namespace ArrLibrary
{
    public class ArrayCl
    {
        //Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
        //Создать свойство Sum, которое возвращает сумму элементов массива, 
        //метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),  
        //метод Multi, умножающий каждый элемент массива на определённое число, 
        //свойство MaxCount, возвращающее количество максимальных элементов.
        //Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
        public static int[] CreateMassive(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 4 + 1;
            }
            return array;

        }

        public static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public static int[] Inverse(int[] array)
        {
            int[] arrayinv = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayinv[i] = array[i] * (-1);
            }
            return arrayinv;
        }

        public static int[] Multi(int[] array, int multipler)
        {
            int[] mularray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                mularray[i] = (array[i] * (multipler));
            }
            return mularray;
        }

        public static int MaxCount(int[] array)
        {
            int maxnum = 0;
            int maxcount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxnum)
                    maxnum = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxnum)
                    maxcount++;
            }
            return maxcount;

        }
    }
}
