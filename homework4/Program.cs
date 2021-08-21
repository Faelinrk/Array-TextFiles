using System;
using System.IO;
using ArrLibrary;
using System.Collections.Generic;

namespace homework4
{
    static class StaticClass
    {
        //Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
        //Реализуйте задачу 1 в виде статического класса StaticClass;
        //Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
        // *Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
        //**Добавьте обработку ситуации отсутствия файла на диске.
        //Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
        //**** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int*>)


        static void Main(string[] args)
        {
            int[] filearray = GetArFromFile();
            int[] array = new int[20];
            var rand = new Random();
            for (int i = 0; i<array.Length; i++)
            {
                var randint = rand.Next(-10000, 10000);
                array[i] = randint;
                Console.WriteLine($"Случайное число массива {i}: {array[i]}");

            }

            for (int i = 0; i < filearray.Length; i++)
            {
                Console.WriteLine($"Число массива из файла {i}: {filearray[i]}");

            }
            

            Console.WriteLine($"Количество пар чисел, из которых лишь одно делится на 3: {CheckPar(array)}; Количество таковых чисел из файла: {CheckPar(filearray)}");

            int[] funcarray = ArrayCl.CreateMassive(25);
            for (int i = 0; i < filearray.Length; i++)
            {
                Console.WriteLine($"Число массива из метода {i}: {funcarray[i]}");

            }
            Console.WriteLine($"Количество пар чисел из массива, созданного из метода, из которых лишь одно делится на 3: {CheckPar(funcarray)};");
            Console.WriteLine($"Сумма чисел массива, созданного из метода: {ArrayCl.Sum(funcarray)};");
            int[] inversefuncarray = ArrayCl.Inverse(funcarray);
            for (int i = 0; i < filearray.Length; i++)
            {
                Console.WriteLine($"Инверсия числа под индексом {i} массива, созданного из метода: {inversefuncarray[i]}");

            }

            int[] mularray = ArrayCl.Multi(funcarray, 5);
            for (int i = 0; i < filearray.Length; i++)
            {
                Console.WriteLine($"Число под индексом {i} массива, созданного из метода, помноженное на 5: {mularray[i]}");

            }
            Console.WriteLine($"Количество максимальных чисел в массиве, созданном из метода: {ArrayCl.MaxCount(funcarray)};");

            //**** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int*>)
            var h = new Dictionary<int, int>();
            foreach (var i in funcarray)
            {
                int res;
                if (h.TryGetValue(i, out res))
                    h[i] += 1;
                else
                    h.Add(i, 1);
            }
            Console.WriteLine("Количество вхождений каждого элемента в массив, созданный из метода: " + h.Count);
            foreach (var kv in h)
            {
                Console.WriteLine(kv.Key + " (" + kv.Value + ")");
            }
            Console.ReadLine();
        }

        static int CheckPar(int[] array)
        {
            int count = 0;
            int firstint;
            int secint;
            for (int i = 0; i < array.Length - 1; i++)
            {

                    firstint = array[i];
                    secint = array[i  + 1];
                
                if ((firstint % 3 == 0 && secint % 3 != 0) || (secint % 3 == 0 && firstint % 3 != 0))
                    count++;
            }
            return count;
        }

        static int[] GetArFromFile()
        {
            int[] a = { 0 };

            try
            {
                StreamReader sr = new StreamReader("..\\data.txt");
                int N = int.Parse(sr.ReadLine());
                a = new int[N];
                for (int i = 0; i < N; i++)
                {
                    a[i] = int.Parse(sr.ReadLine());
                }
                sr.Close();
                return a;

            }

            catch (Exception ex)
            {
                Console.WriteLine("Файла не существует");
                Console.WriteLine(ex.Message);
            }

            return a;
        }
    }
}

