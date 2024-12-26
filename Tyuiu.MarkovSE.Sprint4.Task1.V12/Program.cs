using Tyuiu.MarkovSE.Sprint4.Task1.V12.Lib;
namespace Tyuiu.MarkovSE.Sprint4.Task1.V12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataService ds = new();
            Console.Title = "Спринт #4 | Выполнил: Марков С. Е. | ИСПб 24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                                ");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                             ");
            Console.WriteLine("* Задание #1                                                               ");
            Console.WriteLine("* Вариант #12                                                              ");
            Console.WriteLine("* Выполнил: Марков С.Е. | ИИПб 24-1                                        ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный          ");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 9 подсчитать произведение    ");
            Console.WriteLine("* ечетных элементов массива.  С клавиатуры: 4,8,6,4,9,5,8,7,8,4,7,6,8      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите длину массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("Введите значение: " + i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(array));
            Console.ReadKey();
        }
    }
}