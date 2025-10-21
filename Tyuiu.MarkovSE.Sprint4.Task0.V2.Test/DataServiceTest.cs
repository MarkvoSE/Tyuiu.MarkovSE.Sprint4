using Tyuiu.MarkovSE.Sprint4.Task0.V2.Lib;
namespace Tyuiu.MarkovSE.Sprint4.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int wait = 44;
            int[] array = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int res = ds.GetSumOddArrEl(array);

            Assert.AreEqual(wait, res);
        }
    }
}