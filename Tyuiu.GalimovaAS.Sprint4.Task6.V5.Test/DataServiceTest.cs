using Tyuiu.GalimovaAS.Sprint4.Task6.V5.Lib;
namespace Tyuiu.GalimovaAS.Sprint4.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var array = new string[] { "????????", "??????", "?????", "????", "??????", "??????", "????", "??????" };
            int res = ds.Calculate(array);
            int wait = 1;

            Assert.AreEqual(res, wait);
        }
    }
}