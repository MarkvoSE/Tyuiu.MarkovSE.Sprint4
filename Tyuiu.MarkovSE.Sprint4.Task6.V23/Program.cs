using Tyuiu.MarkovSE.Sprint4.Task6.V23.Lib;
namespace Tyuiu.MarkovSE.Sprint4.Task6.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Марков С.Е | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Марков С.Е. | ИСПб-24-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных                                             *");
            Console.WriteLine("* [Microsoft,Google,Apple,Amazon,Facebook,Tesla,Netflix]                  *");
            Console.WriteLine("* используя класс Array подсчитайте количество  элементов, длина          *");
            Console.WriteLine("* которых равна 6.                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService dataService = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string[] company = new string[] { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };
            Console.WriteLine("Исходный массив:");
            foreach (string companyItem in company)
            {
                Console.WriteLine(companyItem);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов, длина которых равна 6 = " + dataService.Calculate(company));

            Console.ReadKey();
        }
    }
}