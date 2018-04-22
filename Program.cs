using System;

namespace shaffle2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "Alex", "Donald", "Brain", "Tom" };  // инициализация массива строк

            Shaffle data = new Shaffle(str);   // создать (ссылку на) объект типа Shaffe, который принимает  
                                               // в качестве аргумента массив типа string

            data.DisplayData();                // вывести на экран исходный массив 
            data.MixData();                    // переставить элементы массива
            data.DisplayData();                // вывести на экран массив   

        }
    }
}
