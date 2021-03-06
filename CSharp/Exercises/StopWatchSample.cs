﻿using System;
using System.Diagnostics;

namespace Kurslar.CSharp.Exercises
{
    public class StopWatchSample
    {
        void Run()
        {
            Stopwatch kronometre = new Stopwatch();
            kronometre.Start();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            kronometre.Stop();
            TimeSpan zaman = kronometre.Elapsed;

            string gecenZaman = $"{zaman.Hours:00}" +
                                $":{zaman.Minutes:00}" +
                                $":{zaman.Seconds:00}" +
                                $".{zaman.Milliseconds / 10:00}";


            Console.WriteLine("--------------------------");
            Console.Write("Süre : ");
            Console.WriteLine(gecenZaman);

            // SON
            Console.ReadKey();
        }
    }
}