using Tyuiu.GalimovaAS.Sprint4.Task0.V27.Lib;
namespace Tyuiu.GalimovaAS.Sprint4.Task0.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Галимовва А.С. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                        *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                                                      *");
            Console.WriteLine("* Задание #0                                                                                       *");
            Console.WriteLine("* Вариант #27                                                                                      *");
            Console.WriteLine("* Выполнила: Галимовва А.С.  | АСОиУБ - 24-1                                                       *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный статическими значениями в       *");
            Console.WriteLine("* диапазоне от 0 до 9 подсчитать произведение нечетных элементов массива                           *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            int[] array = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };

            Console.WriteLine("Исходный масив");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();


            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            int res = ds.GetMultOddArrEl(array);
            Console.WriteLine(" Произведение нечетных элементов массива:" + res);

            Console.ReadKey();
        }
    }
}
