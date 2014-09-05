using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

    struct Obj
    {
        public int x;
        public int y;
        public string str;
        public ConsoleColor color;
    }
    class FallingRocks
    {
        private static Random _random = new Random();
        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }
        static void PrintOnPosition(int x, int y, string c,
                                    ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(c);
        }

        static void PrintStringOnPosition(int x, int y, string str,
                                    ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        static void Main(string[] args)
        {
            int playFielWidth = 20,liveCount=5;
            
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            Obj userObj = new Obj();
            userObj.x = 2;
            userObj.y = Console.WindowHeight - 1;
            userObj.str = "(0)";
            userObj.color=ConsoleColor.White;
            Random randomGenerator = new Random();
            List<Obj> rocks=new List<Obj>();
            while (true)
            {
                Obj newRock = new Obj();
                string[] arrOfRock = new string[5];
                arrOfRock[0] = "o"; arrOfRock[1] = "$"; arrOfRock[2] = "#"; arrOfRock[3] = "%";
                arrOfRock[4] = "@";
                int obj = randomGenerator.Next(0, 4);
                newRock.color = GetRandomConsoleColor();
                newRock.x = randomGenerator.Next(0, playFielWidth);
                newRock.y = 0;
                newRock.str = arrOfRock[obj];
                rocks.Add(newRock);
                if (Console.KeyAvailable)//is press button
                {
                    ConsoleKeyInfo pressKey = Console.ReadKey(true);
                    while (Console.KeyAvailable) Console.ReadKey(true);
                    if (pressKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (userObj.x > 0)
                        {
                            userObj.x--;
                        }
                    }
                    else if (pressKey.Key == ConsoleKey.RightArrow)
                    {
                        if (userObj.x <playFielWidth)
                        {
                            userObj.x++;
                        }
                    }
                }

                List<Obj> newList = new List<Obj>();
                for (int i = 0; i < rocks.Count; i++)
                {
                    Obj oldRock = rocks[i];
                    Obj nRock = new Obj();
                    nRock.x = oldRock.x;
                    nRock.str = oldRock.str;
                    nRock.color = oldRock.color;
                    nRock.y = oldRock.y + 1;
                    if (nRock.y == userObj.y && nRock.x >= userObj.x && nRock.x <= ((int)userObj.x+2))
                    {
                        liveCount--;
                    }
                    if (liveCount > 0)
                    {
                        if (nRock.y < Console.WindowHeight)
                        {
                            newList.Add(nRock);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Game Over!");
                        break;
                    }
                }
                rocks = newList;
 
                Console.Clear();
                PrintOnPosition(userObj.x, userObj.y, userObj.str, userObj.color);
                foreach (Obj car in rocks)
                {
                    PrintOnPosition(car.x, car.y, car.str, car.color);
                }
                if (liveCount > 0)
                {
                    PrintStringOnPosition(20, 4, "Lives:" + liveCount, ConsoleColor.White);
                }
                else PrintStringOnPosition(8, 4, "Game Over!!!", ConsoleColor.Red);
                Thread.Sleep(200);
            }
        }
    }
