using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GalimovaAS.Sprint4.Task3.V29.Lib
{
    public class DataService : ISprint4Task3V29
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int res = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 1)
                    {
                        res *= array[i, j];
                    }
                }
            }
            return res;
        }
    }
}
