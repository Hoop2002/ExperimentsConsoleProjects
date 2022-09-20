 using System;

namespace ExperimentsProject
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите номер пункта:" +
                    "\n1.Эксперемент с ОП" +
                    "\n2.Рекурсивный метод и нерекурсивный" +
                    "\n3.Время выполнение алгоритма" +
                    "\n0.Выйти из утилиты");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 0)
                    break;
                switch (choice)
                {
                    case 1:
                        ExperimentWithRAM.ExtWR();
                        break;
                    case 2:
                        ExperimentWithRecursion.ExtWRec();
                        break;
                    case 3:
                        AlgorithmExeTime.AltmExeTime();
                        break;
                    default:
                        Console.WriteLine("Такого варианта не существует...");
                        Main();
                        break;
                } 
            }
        }
    }
}
