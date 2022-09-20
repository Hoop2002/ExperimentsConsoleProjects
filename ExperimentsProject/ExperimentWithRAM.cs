using System;
using System.Collections.Generic;


namespace ExperimentsProject
{
   
    class ExperimentWithRAM
    {
        static List<byte[]> buffer = new List<byte[]>();

        public static void ExtWR()
        {
            Console.WriteLine("Будьте осторожнее с данной функцией!!!(Можно сказать она является неким вирусом)");
            Console.WriteLine("1.Выполнение алгоритма\n0.Назад");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 0)
                Program.Main();
            if (choice == 1)
            {

                Console.WriteLine("Выберите скорость:\n1. x2\n2. x5\n3. x10 (на свой страх и риск)");
                int ch = int.Parse(Console.ReadLine());
                int a = 1000;
                switch (ch)
                {
                    case 1:
                        a *= 100;
                        break;
                    case 2:
                        a *= 100000;
                        break;
                    case 3:
                        a *= 199999;
                        break;
                }
                while (true)
                {
                    var buff = new byte[a];
                    for (int i = 0; i < buff.Length; i++)
                    {
                        buff[i] = 1;
                    }

                    buffer.Add(buff);
                    if (ch == 3)
                        Console.WriteLine($"Каждые 200Мб в ОП - {buffer.Count}");
                    else
                        Console.WriteLine($"Мб в ОП - {buffer.Count}");

                }
            }
        }
    }
}
