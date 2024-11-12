using Tyuiu.GalimovaAS.Sprint4.Task2.V22.Lib;
namespace Tyuiu.GalimovaAS.Sprint4.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 4, 1, 6, 4, 5, 5, 6, 4, 2, 4, 3, 6, 4 };

            int res = ds.Calculate(array);
            int wait = 75;

            Assert.AreEqual(res, wait);
        }
    }
}