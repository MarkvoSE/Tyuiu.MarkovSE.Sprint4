using Tyuiu.MarkovSE.Sprint4.Task4.V13.Lib;
namespace Tyuiu.MarkovSE.Sprint4.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Test()
        {
           
            int[,] matrix = {
                {6, 3, 5, 7, 5},
                {3, 5, 7, 4, 5},
                {5, 6, 4, 5, 4},
                {7, 4, 7, 3, 3},
                {4, 6, 5, 5, 6}
            };
            DataService dataService = new DataService();
            int expectedSum = 44; 

           
            int actualSum = dataService.Calculate(matrix);

            
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}