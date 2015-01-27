/*Problem 12.** Falling Rocks

    Implement the "Falling Rocks" game in the text console.
        A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
        A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
        Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
    Ensure a constant game speed by Thread.Sleep(150).
    Implement collision detection and scoring system.
*/


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FallingRocks
{
    class FallingRocksGame
    {
        struct user
        {
            public int rowX;
            public int columY;
            public string symbol;
            public ConsoleColor userColor;

        }
        struct rock
        {
            public int rowX;
            public int columY;
            public string symbol;
            public ConsoleColor rockColor;
        }
        static void printOnPosition(int rowX, int columY, string symbol, ConsoleColor color)
        {
            Console.SetCursorPosition(rowX, columY);
            Console.ForegroundColor = color;
            Console.Write(symbol);
        }
        static void printOnInfoPosition(int rowX, int columY, string symbol, ConsoleColor color)
        {
            Console.SetCursorPosition(rowX, columY);
            Console.ForegroundColor = color;
            Console.Write(symbol);
        }
        static void Main()
        {

            int playFild = 50;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 70;

            user newUser = new user();
            newUser.rowX = playFild / 2;
            newUser.columY = Console.WindowHeight - 1;
            newUser.symbol = "0";
            newUser.userColor = ConsoleColor.White;



            Random randomGenerator = new Random();
            int livesCount = 5;
            int score = 0;
            int newScore = 0;
            int speed = 0;
            int level = 1;


            List<rock> rocks = new List<rock>();

            while (true)
            {

                bool hitted = false;
                {
                    Random colorRandom = new Random();
                    ConsoleColor[] color = new ConsoleColor[8] { ConsoleColor.Cyan, ConsoleColor.Gray, ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow, ConsoleColor.Magenta, ConsoleColor.DarkCyan };
                    Random symbolRandom = new Random();
                    string[] symbol = new string[12] { "!", "@", "#", "$", "%", "^", "&", "*", "+", ".", ";", "B" };
                    string newSymbol = symbol[symbolRandom.Next(0, 12)];

                    rock newRock = new rock();
                    newRock.rowX = randomGenerator.Next(0, playFild);
                    newRock.columY = 0;
                    newRock.symbol = newSymbol;
                    newRock.rockColor = color[colorRandom.Next(0, 8)];
                    rocks.Add(newRock);
                }

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable) Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (newUser.rowX - 1 >= 0)
                        {
                            newUser.rowX--;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (newUser.rowX + 1 < playFild)
                        {
                            newUser.rowX++;
                        }
                    }
                }
                List<rock> newList = new List<rock>();
                for (int i = 0; i < rocks.Count; i++)
                {
                    rock oldRock = rocks[i];
                    rock newRock = new rock();
                    newRock.rowX = oldRock.rowX;
                    newRock.columY = oldRock.columY + 1;
                    newRock.symbol = oldRock.symbol;
                    newRock.rockColor = oldRock.rockColor;

                    if ((newRock.columY == newUser.columY && newRock.rowX == newUser.rowX) && (newRock.symbol == "B"))
                    {
                        score++;
                        newScore = score;
                        if ((newScore % 10) == 0)
                        {
                            level++;
                            speed = speed + 10;
                        }

                    }

                    else if (newRock.columY == newUser.columY && newRock.rowX == newUser.rowX)
                    {
                        livesCount--;
                        speed = 0;
                        hitted = true;

                        if (livesCount <= 0)
                        {
                            printOnInfoPosition(52, 11, "GAME OVER", ConsoleColor.Green);
                            printOnInfoPosition(51, 12, "Press ENTER to exit", ConsoleColor.Green);
                            Console.ReadLine();
                            return;
                        }
                    }
                    if (newRock.columY < Console.WindowHeight)
                    {
                        newList.Add(newRock);
                    }

                }
                rocks = newList;
                Console.Clear();

                if (hitted)
                {
                    rocks.Clear();
                    printOnPosition(newUser.rowX, newUser.columY, "X", ConsoleColor.Red);
                }
                else
                {
                    printOnPosition(newUser.rowX, newUser.columY, newUser.symbol, newUser.userColor);
                }
                foreach (rock rock in rocks)
                {
                    printOnPosition(rock.rowX, rock.columY, rock.symbol, rock.rockColor);
                }

                printOnInfoPosition(48, 1, "Info for Falling Rocks", ConsoleColor.Green);
                printOnInfoPosition(52, 6, "\"B\"is point", ConsoleColor.Green);
                printOnInfoPosition(52, 10, "Lives:" + livesCount, ConsoleColor.Green);
                printOnInfoPosition(52, 11, "Score:" + score, ConsoleColor.Green);
                printOnInfoPosition(52, 12, "Level:" + level, ConsoleColor.Green);
                printOnInfoPosition(52, 13, "Speed:" + speed, ConsoleColor.Green);
                printOnInfoPosition(55, 20, "Controls:", ConsoleColor.Green);
                printOnInfoPosition(52, 22, "     <   >     ", ConsoleColor.Green);
                //Console.Beep();
                Thread.Sleep(150 - speed);
            }
        }
    }
}

