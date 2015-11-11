using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    class Program
    {
        static void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        static void Blue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        static void Gray()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        static void Main(string[] args)
        {
            string[] group = {"Иванов", "Петров", "Сидоров"};
        labl1:
            Red();
            Console.WriteLine("Введите новое имя для поиска:\n");
            Blue();
            string name = Console.ReadLine();
            int k = 3;
            for (int i = 0; i < 3; ++i)
            {
                if (name == group[i])
                {
                    k = i;
                    break;
                }
            }
            try
            {
                Green();
                Console.WriteLine("Имя - {0} есть в списке \n", group[k]);

            }
            catch (IndexOutOfRangeException)
            {
                Green();
                Console.WriteLine("Имя - {0}: не найдено \n", name);
            }
            Gray();
            Console.WriteLine("Хотите еще попробовать ? (да/нет) \n");
            string yn = Console.ReadLine();
            if (yn == "да") goto labl1;
            else
                Console.WriteLine("Тогда Удачи !!");

            Console.ReadKey();
        }
    }
}
