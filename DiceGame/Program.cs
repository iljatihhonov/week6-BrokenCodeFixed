﻿using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Игра в кости
            //Компьюьер (cpu) и пользователь (user) играют в кости 
            //Компьютер "бросает кубик" и пользователь "бросает кубик" (за пользователя тоже играет класс рандом)
            //Значения, которые могут выпасть находятся в диапазоне от 1-6 (включительно)
            //Кто выбросил больший результат, то и победил в игре
            //бросок выполняется один раз
            //исправленный до рабочего состояния код дает до 10 пунктов 

            //комментарии к переменным: userThrow - бросок пользователем; cpuScore - бросок компьютера;


            Console.WriteLine("user vs computer");

            Random rnd = new Random();
            int userThrow;
            int cpuThrow;

            userThrow = rnd.Next(1, 7);
            cpuThrow = rnd.Next(1, 7);

            Console.WriteLine($"User number is: {userThrow}");
            Console.WriteLine($"PC number is:{cpuThrow}");
            if (userThrow < cpuThrow)
            {
                Console.WriteLine("PC Win!");
            }

            if (userThrow > cpuThrow)
            {
                Console.WriteLine("User Win!");
            }
            else if (userThrow == cpuThrow)
            {
                Console.WriteLine("Nobody has won!");
            }

        }
    }
}