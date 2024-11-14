using Tyuiu.GalimovaAS.Sprint4.Task7.V17.Lib;
namespace Tyuiu.GalimovaAS.Sprint4.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 3;
            int m = 3;
            int[,] matrix = new int[n, m];
            string value = "753159864";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, value);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}