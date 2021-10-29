using System;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Starter Code
            int choice = 0;
            DisplayHeader();
            while (true)
            {
                choice = GetMenuSelection();
                switch (choice)
                {
                    case 1:
                        EnterPlayerInformation();
                        break;
                    case 2:
                        DisplayAllPlayers();
                        break;
                    case 3:
                        FilterPlayersByYear();
                        break;
                    case 4:
                        DisplayPlayerCount();
                        break;
                    case 5:
                        ExitProgram();
                        break;
                }
            }
        }
    }
}
