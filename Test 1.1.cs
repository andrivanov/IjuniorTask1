using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using System;

//Избавьтесь от дублирующегося кода и выведите объектную модель.

namespace Task
{
    class Program
    {
        public static void Main(string[] args)
        {
            int obj1x, obj1y, obj2x, obj2y, obj3x, obj3y;
            bool isalive1, isalive2, isalive3;
            PresetPositionsObjects(obj1x, obj1y,  isalive1,  obj2x, obj2y,  isalive2,  obj3x,  obj3y,  isalive3);

            Random random = new Random();

            while (true)
            {
                ObjectPosition( obj1x,  obj1y,  obj2x,  obj2y,  obj3x,  obj3y,  isalive1,  isalive2,  isalive3, random);

                DrawCommands(obj1x, obj1y, obj2x, obj2y, obj3x, obj3y, isalive1, isalive2, isalive3);
            }
        }

        private static void DrawCommands(int obj1x, int obj1y, int obj2x, int obj2y, int obj3x, int obj3y, bool isalive1, bool isalive2, bool isalive3)
        {
            if (isalive1)
            {
                Console.SetCursorPosition(obj1x, obj1y);
                Console.Write("1");
            }

            if (isalive2)
            {
                Console.SetCursorPosition(obj2x, obj2y);
                Console.Write("2");
            }

            if (isalive3)
            {
                Console.SetCursorPosition(obj3x, obj3y);
                Console.Write("3");
            }
        }

        private static void ObjectPosition( int obj1x,  int obj1y,  int obj2x,  int obj2y,  int obj3x,  int obj3y,  bool isalive1,  bool isalive2,  bool isalive3, Random random)
        {
            if (obj1x == obj2x && obj1y == obj2y)
            {
                isalive1 = false;
                isalive2 = false;
            }

            if (obj1x == obj3x && obj1y == obj3y)
            {
                isalive1 = false;
                isalive3 = false;
            }

            if (obj2x == obj3x && obj2y == obj3y)
            {
                isalive2 = false;
                isalive3 = false;
            }

            RandomPosition( obj1x,  obj1y, obj2x,  obj2y,  obj3x, obj3y, random);

            if (obj1x < 0)
                obj1x = 0;

            if (obj1y < 0)
                obj1y = 0;

            if (obj2x < 0)
                obj2x = 0;

            if (obj2y < 0)
                obj2y = 0;

            if (obj3x < 0)
                obj3x = 0;

            if (obj3y < 0)
                obj3y = 0;
        }

        private static void RandomPosition( int obj1x,  int obj1y,  int obj2x,  int obj2y, int obj3x,  int obj3y, Random random)
        {
            obj1x += random.Next(-1, 1);
            obj1y += random.Next(-1, 1);

            obj2x += random.Next(-1, 1);
            obj2y += random.Next(-1, 1);

            obj3x += random.Next(-1, 1);
            obj3y += random.Next(-1, 1);
        }

        private static void PresetPositionsObjects( int obj1x,  int obj1y,  bool isalive1,  int obj2x,  int obj2y,  bool isalive2, int obj3x,  int obj3y, out bool isalive3)
        {
            obj1x = 5;
            obj1y = 5;
            isalive1 = true;
            obj2x = 10;
            obj2y = 10;
            isalive2 = true;
            obj3x = 15;
            obj3y = 15;
            isalive3 = true;
        }
    }
}