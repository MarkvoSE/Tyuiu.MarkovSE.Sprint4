using Tyuiu.MarkovSE.Sprint4.Task6.V23.Lib;
namespace Tyuiu.MarkovSE.Sprint4.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService dataService = new DataService();
            string[] company = new string[] { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };
            Assert.AreEqual(2, dataService.Calculate(company));

        }
    }
}