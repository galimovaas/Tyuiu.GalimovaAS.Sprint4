using Tyuiu.GalimovaAS.Sprint4.Task5.V29.Lib;
namespace Tyuiu.GalimovaAS.Sprint4.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas4 = new int[5, 5] { { 5, -2, 7, 0, 5 },
                                          { 5, 5, 5, -5, 4 },
                                          { -9, 9, 5, -3, 2 },
                                          { -2, 8, 4, 4, 2 },
                                          { -5, 6, 0, -5, -7 } };

            int res = ds.Calculate(mas4);
            int wait = 15;
            Assert.AreEqual(wait, res);
        }
    }
}