using Tyuiu.GalimovaAS.Sprint4.Task2.V22.Lib;
namespace Tyuiu.GalimovaAS.Sprint4.Task2.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Галимова А.С. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                        *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                                                     *");
            Console.WriteLine("* Задание #2                                                                                       *");
            Console.WriteLine("* Вариант #22                                                                                      *");
            Console.WriteLine("* Выполнила: Галимова А.С. | АСОиУБ - 24-1                                                         *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов, заполненный статическими значениями в       *");
            Console.WriteLine("* диапазоне от 1 до 6 подсчитать произведение нечетных элементов массива                           *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            int len;
            Console.WriteLine("Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("Введите значение " + i + " элементов массива: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i <= len - 1; ++i)
            {
                Console.Write(numsArray[i] + " \t " + " \t ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Произведение нечетных элементов массива равна: " + res);
            Console.ReadKey();
        }
    }
}
