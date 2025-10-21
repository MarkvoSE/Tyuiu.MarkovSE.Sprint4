using Tyuiu.MarkovSE.Sprint4.Task0.V2.Lib;
namespace Tyuiu.MarkovSE.Sprint4.Task0.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Марков С.Е. | ИСПБ-24-1";
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы (статический ввод)                                   *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Марков С.Е. | ИСПБ-24-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");


            Console.WriteLine("*Дан одномерный целочисленный массив на 10 элементов заполненный статическ*");
            Console.WriteLine("*кими значениями в диапазоне от 0 до 9 подсчитать сумму нечетных элементов*");
            Console.WriteLine("*в массива.                                                               *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            Console.WriteLine("Массив:");
            foreach (int numb in array)
            {
                Console.WriteLine(numb);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.GetSumOddArrEl(array);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}