using System.Diagnostics;
using Tyuiu.MarkovSE.Sprint4.Task7.V17.Lib;
namespace Tyuiu.MarkovSE.Sprint4.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int m = 0;
            int n = 0;
            Console.Title = "Спринт #4 | Выполнил: Марков С.Е | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Марков С.Е. | ИСПб-24-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            DataService dataService = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
           
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат:");
            DataService ds = new DataService();
            string value = "753159864";
            int[] oneDimensionalArray = value.Select(c => int.Parse(c.ToString())).ToArray();

            Console.WriteLine(string.Join(", ", oneDimensionalArray));
            int[,] twoDimensionalArray = new int[3, 3];
            int k = 0;

            for (n = 0; n < 3; n++)
            {
                for (m = 0; m < 3; m++)
                {
                    twoDimensionalArray[n, m] = oneDimensionalArray[k++];
                }
            }
            int evenCount = 0;
            for (n = 0; n < 3; n++)
            {
                for (m = 0; m < 3; m++)
                {
                    if (twoDimensionalArray[n, m] % 2 == 0)
                    {
                        evenCount++;
                    }
                }
            }

            PrintMatrix(twoDimensionalArray);


            static void PrintMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("EvenCount:" + evenCount);
        }
    }
}