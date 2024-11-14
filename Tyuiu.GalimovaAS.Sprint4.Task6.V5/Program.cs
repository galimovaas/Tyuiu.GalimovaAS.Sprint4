using Tyuiu.GalimovaAS.Sprint4.Task6.V5.Lib;
namespace Tyuiu.GalimovaAS.Sprint4.Task6.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Галимова А.С. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                        *");
            Console.WriteLine("* Тема: Класс Array                                                                                *");
            Console.WriteLine("* Задание #6                                                                                       *");
            Console.WriteLine("* Вариант #5                                                                                       *");
            Console.WriteLine("* Выполнила: Галимова А.С. | АСОиУБ - 24-1                                                         *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Дан строковый массив данных, используя класс Array подсчитайте количество элементов, длина       *");
            Console.WriteLine("* которых 5                                                                                        *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            var array = new string[] { "Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун" };

            Console.WriteLine(" Исходный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine(" Количество элементов, длина которых = 5: ");

            int nums = ds.Calculate(array);
            Console.WriteLine(nums);

            Console.ReadKey();
        }
    }
}
