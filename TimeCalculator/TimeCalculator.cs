namespace TimeCalculator
{
    internal class TimeCalculator
    {
        static void Main()
        {
            Clock clock1 = new Clock();
            Clock clock2 = new Clock();
            Clock clockDelta = new Clock();

            Dictionary<int, Action> numCloclPos = new Dictionary<int, Action>();
            numCloclPos.Add(0, () => Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2 - 2));
            numCloclPos.Add(1, () => Console.SetCursorPosition(Console.WindowWidth / 2 - 14, Console.WindowHeight / 2 - 2));
            numCloclPos.Add(2, () => Console.SetCursorPosition(Console.WindowWidth / 2 - 12, Console.WindowHeight / 2 - 2));
            numCloclPos.Add(3, () => Console.SetCursorPosition(Console.WindowWidth / 2 - 11, Console.WindowHeight / 2 - 2));
            numCloclPos.Add(4, () => Console.SetCursorPosition(Console.WindowWidth / 2 + 8, Console.WindowHeight / 2 - 2));
            numCloclPos.Add(5, () => Console.SetCursorPosition(Console.WindowWidth / 2 + 9, Console.WindowHeight / 2 - 2));
            numCloclPos.Add(6, () => Console.SetCursorPosition(Console.WindowWidth / 2 + 11, Console.WindowHeight / 2 - 2));
            numCloclPos.Add(7, () => Console.SetCursorPosition(Console.WindowWidth / 2 + 12, Console.WindowHeight / 2 - 2));


            int selectedClockNum = 4;


            DrawBorder();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 11, 0);
            Console.Write("КАЛЬКУЛЯТОР ВРЕМЕНИ");

            DrawTimeInfo();
            DrawControl();

            numCloclPos[selectedClockNum]();

            while (true)
            {
                int x = Console.CursorLeft;
                int y = Console.CursorTop;
                ConsoleKey pressedKey = Console.ReadKey().Key;
                Console.SetCursorPosition(x, y);
                DrawTimeInfo();
                if (pressedKey == ConsoleKey.RightArrow || pressedKey == ConsoleKey.D)
                {
                    selectedClockNum = (selectedClockNum + 1) % 8;
                    numCloclPos[selectedClockNum]();
                }
                else if (pressedKey == ConsoleKey.LeftArrow || pressedKey == ConsoleKey.A)
                {
                    selectedClockNum = (selectedClockNum + 7) % 8;
                    numCloclPos[selectedClockNum]();
                }
                else if (pressedKey == ConsoleKey.UpArrow || pressedKey == ConsoleKey.W)
                {
                    switch (selectedClockNum)
                    {
                        case 0:
                            clock1.TenHoursUp();
                            break;
                        case 1:
                            clock1.HoursUp();
                            break;
                        case 2:
                            clock1.TenMinutesUp();
                            break;
                        case 3:
                            clock1.MinutesUp();
                            break;
                        case 4:
                            clock2.TenHoursUp();
                            break;
                        case 5:
                            clock2.HoursUp();
                            break;
                        case 6:
                            clock2.TenMinutesUp();
                            break;
                        case 7:
                            clock2.MinutesUp();
                            break;
                    }
                    //Console.SetCursorPosition(x, y);
                    DrawTimeInfo();
                    Console.SetCursorPosition(x, y);
                }
                else if (pressedKey == ConsoleKey.DownArrow || pressedKey == ConsoleKey.S)
                {
                    switch (selectedClockNum)
                    {
                        case 0:
                            clock1.TenHoursDown();
                            break;
                        case 1:
                            clock1.HoursDown();
                            break;
                        case 2:
                            clock1.TenMinutesDown();
                            break;
                        case 3:
                            clock1.MinutesDown();
                            break;
                        case 4:
                            clock2.TenHoursDown();
                            break;
                        case 5:
                            clock2.HoursDown();
                            break;
                        case 6:
                            clock2.TenMinutesDown();
                            break;
                        case 7:
                            clock2.MinutesDown();
                            break;
                    }
                    //Console.SetCursorPosition(x, y);
                    DrawTimeInfo();
                    Console.SetCursorPosition(x, y);
                }
                else if (pressedKey == ConsoleKey.R)
                {
                    clock1.Time = 0;
                    clock2.Time = 0;
                    DrawTimeInfo();
                }
            }

            Console.SetCursorPosition(2, 10);

            void DrawTimeInfo()
            {
                clockDelta.Time = clock2.Time - clock1.Time;
                if (clockDelta.Time < 0)
                {
                    clockDelta.Time = 1440 + clockDelta.Time;
                }
                Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.WindowHeight / 2 - 3);
                Console.Write($"{clockDelta.Hours}:{clockDelta.Minutes}");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2 - 2);
                Console.Write($"{clock1.Hours}:{clock1.Minutes} ===============> {clock2.Hours}:{clock2.Minutes}");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 4, Console.WindowHeight / 2 - 1);
                Console.Write($"{clockDelta.Time} min     ");
                numCloclPos[selectedClockNum]();
            }

            static void DrawControl()
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 35, Console.WindowHeight - 2);
                Console.Write("← / A - Left   → / D - Right   ↑ / W - Up   ↓ / S - Down   R - reset");
            }

            static void DrawBorder()
            {
                Console.Write('*');
                for (int i = 1; i < Console.WindowWidth - 1; i++)
                {
                    Console.SetCursorPosition(i, 0);
                    Console.Write('-');
                    Console.SetCursorPosition(i, Console.WindowHeight - 1);
                    Console.Write('-');
                }
                for (int i = 1; i < Console.WindowHeight - 1; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write('|');
                    Console.SetCursorPosition(Console.WindowWidth - 1, i);
                    Console.Write('|');
                }
                Console.SetCursorPosition(Console.WindowWidth - 1, 0);
                Console.Write('*');
                Console.SetCursorPosition(Console.WindowWidth - 1, Console.WindowHeight - 1);
                Console.Write('*');
                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                Console.Write('*');
            }
        }
    }
}