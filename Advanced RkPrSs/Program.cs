using System;

namespace Advanced_RkPrSs
{
    class Program
    {
        static void Main(string[] args)
        {
            string rock = "Rock";
            string paper = "Paper";
            string scissors = "Scissors";
            int win = 0;
            int draw = 0;
            int lose = 0;
            int userMenuNumber = 1;
            while (userMenuNumber > 0)
            {
                string userName = "No User Logged In";
                Console.Title = rock + ", " + paper + ", " + scissors + " - User: " + userName;
                PrintBlockTitle("User Login Screen");
                PrintColourMessage(ConsoleColor.Red, "Welcome to " + rock + ", " + paper + ", " + scissors + "!");
                PrintColourMessageLine(ConsoleColor.White, "\nWhat is your name? ");
                userName = Console.ReadLine();
                while (userMenuNumber < 4)
                {
                    Console.Title = rock + ", " + paper + ", " + scissors + " - User: " + userName;
                    PrintBlockTitle("Main Menu");
                    PrintColourMessage(ConsoleColor.Blue, "User: " + userName+"\n");
                    PrintColourScore(win, draw, lose);
                    PrintColourMessage(ConsoleColor.White, "\n\n1. Start Game\n\n2. Settings\n\n3. Change User\n\n4. Exit");
                    PrintColourMessageLine(ConsoleColor.White, "\nSelect an Option > ");
                    string userMenu = Console.ReadLine();
                    if (!int.TryParse(userMenu, out userMenuNumber))
                    {
                        continue;
                    }
                    userMenuNumber = Int32.Parse(userMenu);
                    if (userMenuNumber > 4)
                    {
                        userMenuNumber = 0;
                        continue;
                    }
                    if (userMenuNumber == 1)
                    {
                        int intMainGame = 1;
                        while (intMainGame > 0)
                        {
                            Random random = new Random();
                            int ComputerAttempt = random.Next(1, 4);
                            PrintBlockTitle("Main Game");
                            PrintColourScore(win, draw, lose);
                            PrintColourMessage(ConsoleColor.White, "\n\nWelcome to " + rock + ", " + paper + ", " + scissors + "\n");
                            PrintColourMessage(ConsoleColor.Green, "1. " + rock + "\n2. " + paper + "\n3. " + scissors + "\n");
                            PrintColourMessageLine(ConsoleColor.White, "Please select an Option (0 to exit)> ");
                            string stringMainGame = Console.ReadLine();
                            if (!int.TryParse(stringMainGame, out intMainGame))
                            {
                                intMainGame = 1;
                                continue;
                            }
                            intMainGame = Int32.Parse(stringMainGame);
                            if (intMainGame > 3)
                            {
                                intMainGame = 1;
                            }
                            PrintColourMessageLine(ConsoleColor.Blue, "\nComputer selected: ");
                            if (ComputerAttempt == 1)
                            {
                                Console.Write(rock);
                            }
                            if (ComputerAttempt == 2)
                            {
                                Console.Write(paper);
                            }
                            if (ComputerAttempt == 3)
                            {
                                Console.Write(scissors);
                            }
                            PrintColourMessageLine(ConsoleColor.Green, "\n" + userName + " entered: ");
                            if (intMainGame == 1)
                            {
                                PrintColourMessageLine(ConsoleColor.White, rock + "\n");
                            }
                            if (intMainGame == 2)
                            {
                                PrintColourMessageLine(ConsoleColor.White, paper + "\n");
                            }
                            if (intMainGame == 3)
                            {
                                PrintColourMessageLine(ConsoleColor.White, scissors + "\n");
                            }
                            if (intMainGame == 1)
                            {
                                if (ComputerAttempt == 1)
                                {
                                    Console.Write("\n{0} smashes {0} but nothing really happens ", rock);
                                    draw = draw + 1;
                                    resultFunc(ConsoleColor.Yellow, "Draw!");
                                }
                                if (ComputerAttempt == 2)
                                {
                                    Console.Write("\n{0} covers {1} ", paper, rock);
                                    lose = lose + 1;
                                    resultFunc(ConsoleColor.Red, "Lose!");
                                }
                                if (ComputerAttempt == 3)
                                {
                                    Console.Write("\n{0} breaks {1} ", rock, scissors);
                                    win = win + 1;
                                    resultFunc(ConsoleColor.Green, "Win!");
                                }
                            }
                            if (intMainGame == 2)
                            {
                                if (ComputerAttempt == 1)
                                {
                                    Console.Write("\n{0} covers {1} ", paper, rock);
                                    win = win + 1;
                                    resultFunc(ConsoleColor.Green, "Win!");
                                }
                                if (ComputerAttempt == 2)
                                {
                                    Console.Write("\n{0} rubs against {0} ", paper);
                                    draw = draw + 1;
                                    resultFunc(ConsoleColor.Yellow, "Draw!");
                                }
                                if (ComputerAttempt == 3)
                                {
                                    Console.Write("\n{0} cut {1} ", scissors, paper);
                                    lose = lose + 1;
                                    resultFunc(ConsoleColor.Red, "Lose!");
                                }
                            }
                            if (intMainGame == 3)
                            {
                                if (ComputerAttempt == 1)
                                {
                                    Console.Write("\n{0} breaks {1} ", rock, scissors);
                                    lose = lose + 1;
                                    resultFunc(ConsoleColor.Red, "Lose!");
                                }
                                if (ComputerAttempt == 2)
                                {
                                    Console.Write("\n{0} cut {1} ", scissors, paper);
                                    win = win + 1;
                                    resultFunc(ConsoleColor.Green, "Win!");
                                }
                                if (ComputerAttempt == 3)
                                {
                                    Console.Write("\n{0} just rub together creating sparks ", scissors);
                                    draw = draw + 1;
                                    resultFunc(ConsoleColor.Yellow, "Draw!");
                                }
                            }      
                        }
                    }
                    if (userMenuNumber == 2)
                    {
                        int userSettings = 1;

                        while (userSettings > 0)
                        {
                            PrintBlockTitle("Settings");
                            PrintColourMessage(ConsoleColor.Red, "Which name would you like to change:\n");
                            PrintColourMessage(ConsoleColor.Green, "1. " + rock + "\n2. " + paper + "\n3. " + scissors+"\n");
                            PrintColourMessageLine(ConsoleColor.White, "Please select a number (Press 0 to exit) > ");
                            string userSetting = Console.ReadLine();
                            if (!int.TryParse(userSetting, out userSettings))
                            {
                                userSettings = 4;
                                continue;
                            }
                            userMenuNumber = Int32.Parse(userSetting);
                            if (userSettings > 3)
                            {
                                continue;
                            }
                            if (userSettings == 1)
                            {
                                PrintColourMessageLine(ConsoleColor.Red, "What would you like to change " + rock + " to? ");
                                rock = Console.ReadLine();
                                continue;
                            }
                            if (userSettings == 2)
                            {
                                PrintColourMessageLine(ConsoleColor.Red, "What would you like to change " + paper + " to? ");
                                paper = Console.ReadLine();
                                continue;
                            }
                            if (userSettings == 3)
                            {
                                PrintColourMessageLine(ConsoleColor.Red, "What would you like to change " + scissors + " to? ");
                                scissors = Console.ReadLine();
                                continue;
                            }  
                        }
                    }
                    if (userMenuNumber == 3)
                    {
                        win = 0;
                        draw = 0;
                        lose = 0;
                        break;
                    }
                    if (userMenuNumber == 4)
                    {
                        PrintBlockTitle("Exit Screen");
                        PrintColourMessageLine(ConsoleColor.Red, "Are you sure you want to exit? (y or n) > ");
                        string userExit;
                        userExit = Console.ReadLine();
                        if (userExit == "y")
                        {
                            return;
                        }
                        if (userExit == "Y")
                        {
                            return;
                        }
                        else
                        {
                            userMenuNumber = 0;
                            continue;
                        }
                    }
                }
                
            }
        }
        static void PrintColourMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void PrintColourMessageLine(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
        static void PrintBlockTitle(string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(message+"\n");
            Console.ResetColor();
        }
        static void PrintColourScore(int w, int d, int l)
        {
            PrintColourMessageLine(ConsoleColor.White, "Current Scores - ");
            PrintColourMessageLine(ConsoleColor.Green, "Wins: " + w);
            PrintColourMessageLine(ConsoleColor.Yellow, " Draws: " + d);
            PrintColourMessageLine(ConsoleColor.Red, " Loses: " + l);
        }
        static void debugMessage(string debugMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DEBUG: " + debugMessage);
            Console.ResetColor();
        }
        static void resultFunc(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}

