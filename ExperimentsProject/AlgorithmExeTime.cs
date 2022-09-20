using System;
using System.Diagnostics;
using System.Threading;

namespace ExperimentsProject
{
    class AlgorithmExeTime
    {
        public static void AltmExeTime() 
        {
            Console.WriteLine("Выполнение может занять продолжительное время\n1.Выполнение алгоритма\n0.Назад");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 0)
                Program.Main();
            if (choice == 1)
            {
                Random random = new Random();
                Stopwatch stopWatch = new Stopwatch();
                int num = random.Next();
                stopWatch.Start();
                for (int i = 0; i < num;)
                {
                    i++;
                }
                stopWatch.Stop();
                TimeSpan time = stopWatch.Elapsed;

                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", time.Hours, time.Minutes, time.Seconds, time.Milliseconds / 10);
                Console.WriteLine($"Время выполнения - {elapsedTime}");
            }
        }
    }
}
