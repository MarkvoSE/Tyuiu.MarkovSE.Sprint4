using Tyuiu.MarkovSE.Sprint4.Task3.V11.Lib;
namespace Tyuiu.MarkovSE.Sprint4.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Марков С.Е. | ИСПб-24-1";
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                      *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                          *");
            Console.WriteLine("* Задание #3                                                                     *");
            Console.WriteLine("* Вариaнт #11                                                                     *");
            Console.WriteLine("* Выполнил: Марков С.Е. | ИСПб-24-1                                              *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный случайными     *");
            Console.WriteLine("* в диапазоне от 2 до 9 подсчитать сумму четных элементов массива.               *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            int[,] array = new int[,] { { 8, 6, 9, 4, 5, }, { 9, 4, 8, 5, 6, }, { 9, 7, 9, 8, 4, }, { 4, 6, 5, 7, 8, }, { 6, 6, 7, 6, 4, } };
            int res = ds.Calculate(array);

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine("Количество нечетных элементов во всем массиве = " + res);
            Console.ReadKey();
        }
    }
}