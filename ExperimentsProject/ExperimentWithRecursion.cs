using System;

namespace ExperimentsProject
{
    class ExperimentWithRecursion
    {
        public static void ExtWRec()
        { 
            Console.WriteLine("Введите номер пункта:\n1.Рекурсивный метод\n2.Нерекурсивный метод\n0.Назад");
            int choiceRec = int.Parse(Console.ReadLine());
            if (choiceRec == 0)
                Program.Main();
            switch (choiceRec)
            {
                case 1:
                    Console.WriteLine("Введите число:");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Факториал числа {num} равен - {RecursiveMethod(num)}");
                        break;
                case 2:
                    Console.WriteLine("Введите число:");
                    int num0 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Факториал числа {num0} равен - {NonRecursiveMethod(num0)}");
                        break;
            }
        }

        private static int RecursiveMethod(int numf) //простая реализация рекурсивного метода факториала числа
        {
            if (numf == 1) return 1;
            return numf * RecursiveMethod(numf - 1);
        }

        private static int NonRecursiveMethod(int numf) //простая реализация нерекусивный метод факториала числа
        {
            int factorial = numf;
            for (int i = 1; i < numf; i++) 
            {
                factorial *= i;
            }
                return factorial;   
        }
    }
}
