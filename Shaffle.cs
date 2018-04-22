using System;
using System.Collections.Generic;
using System.Text;

namespace shaffle2
{
    class Shaffle
    {
        // Эти члены класса являются закрытыми.
        private string[] Data;    // массив, содержащий строки  

        // Конструктор построить пустой класс Shaffle для реализации престановок  
        public Shaffle(string[] arr)
        {
            Data = arr; // установить размер для массива
        }

        // Этот метод выводит на экран массив строк 
        public void DisplayData()
        {
            //for (int i = 0; i < Data.Length; i++) 
            //    Console.Write(" {0} ", Data[i]);

            // Метод String.Join (String, String[])Сцепляет все элементы
            // массива строк, помещая между ними заданный разделитель.
            Console.WriteLine(string.Join(", ", Data));
        }

        /// метод для перестановки элементов массива
        public void MixData()
        {
            Random rand = new Random();         // "rand" переменная класса "Random" 
            string temp;                        // для промежуточного хранения значений массива строк
            int r = 0;                          // переменна для сохраненеия целочисленного рандомного значения

            for (int i = Data.Length - 1; i >= 0; --i)
            {
                r = rand.Next(i + 1);           //Next(Int32) Возвращает неотрицательное случайное целое число, 
                temp = Data[r];                 //которое меньше максимально допустимого значения.
                Data[r] = Data[i];
                Data[i] = temp;
            }
        }

    }
}
