using Tyuiu.GalimovaAS.Sprint4.Task1.V12.Lib;
namespace Tyuiu.GalimovaAS.Sprint4.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 4, 8, 6, 4, 9, 5, 8, 7, 8, 4, 7, 6, 8 };

            int res = ds.Calculate(array);
            int wait = 2205;

            Assert.AreEqual(res, wait);
        }
    }
}