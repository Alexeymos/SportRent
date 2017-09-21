using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportInvetoryRent.Board_games;
using SportInvetoryRent.Street;
using System.Threading;

namespace SportInvetoryRent
{
    enum Menuprint
    {
        Economic,
        Logic,
        Bowls,
        Tenis
    }

    class Program
    {
        static BaseInventory[] baseinventory = new BaseInventory[4];

        static void InintArr()
        {
            baseinventory[0] = new Economicgames("Monopoly", 10, "Game on Board", "Economy", 4, 2);
            baseinventory[1] = new Logicgames("Chess", 12, "Game on Board", "Logic", "wood", "plastic");
            baseinventory[2] = new Bowls("MadBall", 20, "Game on street", "on floor", 10, "wood");
            baseinventory[3] = new Tenis("FunyBalls", 25, "Game on street", "on table", "USA", "China");
        }

        static void Main(string[] args)
        {

            InintArr();

            Mainmenu();

        }
        static void Mainmenu()
        {
            while (true)
            {
                Console.Clear();
                char[] arr = new char[28] { '+', '-', '-', '-', '-', '-', '-', '-', '-', 'M', 'a', 'i', 'n', ' ', 'm', 'e', 'n', 'u', '-', '-', '-', '-', '-', '-', '-', '-', '-', '+' };
                for (int i = 0; i < 28; i++)
                {


                    Console.Write(arr[i]);
                    Thread.Sleep(50);
                    Console.SetCursorPosition(i + 1, 0);
                }
                Console.WriteLine();
                StringBuilder sb = new StringBuilder();
                // sb.AppendLine("+--------------------------+");
                sb.AppendLine("| 1- List all inventory    |");
                sb.AppendLine("| 2- Add product           |");
                sb.AppendLine("| 3- List product          |");
                sb.AppendLine("| 4- Exit                  |");
                sb.AppendLine("+--------------------------+");
                Console.WriteLine(sb);
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.Clear();
                    AllInfo();
                }
                if (choice == "2")
                {
                    Console.Clear();
                    AddArr();
                }
                else if (choice == "3")
                {
                    Listproduct();
                }
                else if (choice == "4")
                {
                    break;
                }
                else
                {
                    continue;
                }

            }
        }
        static void Listproduct()
        {
            while (true)
            {
                Console.Clear();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("+-------------LIST-----------+");
                sb.AppendLine("|     1- Economic games      |");
                sb.AppendLine("|     2- Logic    games      |");
                sb.AppendLine("|     3- Bowls    games      |");
                sb.AppendLine("|     4- Tenis    games      |");
                sb.AppendLine("|     5- Exit                |");
                sb.AppendLine("+----------------------------+");
                Console.WriteLine(sb);
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.Clear();
                    for (int i = 0; i < baseinventory.Length; i++)
                    {
                        if (baseinventory[i] is Economicgames)
                        {
                            Console.WriteLine(baseinventory[i].GetType().Name);
                            Console.WriteLine(new string('-', 7));
                            baseinventory[i].Info();
                        }
                    }
                    Console.WriteLine("Press any key");
                    Console.ReadLine();
                    break;
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    for (int i = 0; i < baseinventory.Length; i++)
                    {
                        if (baseinventory[i] is Logicgames)
                        {
                            Console.WriteLine(baseinventory[i].GetType().Name);
                            Console.WriteLine(new string('-', 7));
                            baseinventory[i].Info();
                        }
                    }
                    Console.WriteLine("Press any key");
                    Console.ReadLine();
                    break;
                }
                else if (choice == "3")
                {
                    Console.Clear();
                    for (int i = 0; i < baseinventory.Length; i++)
                    {
                        if (baseinventory[i] is Bowls)
                        {
                            Console.WriteLine(baseinventory[i].GetType().Name);
                            Console.WriteLine(new string('-', 7));
                            baseinventory[i].Info();
                        }
                    }
                    Console.WriteLine("Press any key");
                    Console.ReadLine();
                    break;
                }
                else if (choice == "4")
                {
                    Console.Clear();
                    for (int i = 0; i < baseinventory.Length; i++)
                    {
                        if (baseinventory[i] is Tenis)
                        {
                            Console.WriteLine(baseinventory[i].GetType().Name);
                            Console.WriteLine(new string('-', 7));
                            baseinventory[i].Info();
                        }
                    }
                    Console.WriteLine("Press any key");
                    Console.ReadLine();
                    break;
                }
                else if (choice == "5")
                {
                    break;
                }
            }
        }
        static void AllInfo()
        {
            for (int i = 0; i < baseinventory.Length; i++)
            {
                Console.WriteLine(baseinventory[i].GetType().Name);
                Console.WriteLine(new string('-', 7));
                baseinventory[i].Info();

            }
            Console.ReadLine();
        }
        static void AddArr()
        {
            BaseInventory[] newbasinventory = new BaseInventory[baseinventory.Length + 1];
            for (int i = 0; i < baseinventory.Length; i++)
            {
                newbasinventory[i] = baseinventory[i];
            }
            baseinventory = newbasinventory;//
            while (true)
            {
                Console.Clear();
                char[] arr = new char[28] { '+', '-', '-', '-', '-', '-', '-', '-', '-', '-', 'A', 'd', 'd', ' ', 'm', 'e', 'n', 'u', '-', '-', '-', '-', '-', '-', '-', '-', '-', '+' };
                for (int i = 0; i < 28; i++)
                {


                    Console.Write(arr[i]);
                    Thread.Sleep(50);
                    Console.SetCursorPosition(i + 1, 0);
                }
                Console.WriteLine();
                StringBuilder sb = new StringBuilder();
                sb.Append("| 1- "); sb.Append((Menuprint)0); sb.AppendLine("              |");
                sb.Append("| 2- "); sb.Append((Menuprint)1); sb.AppendLine("                 |");
                sb.Append("| 3- "); sb.Append((Menuprint)2); sb.AppendLine("                 |");
                sb.Append("| 4- "); sb.Append((Menuprint)3); sb.AppendLine("                 |");
                sb.AppendLine("| 5- Exit                  |");
                sb.AppendLine("+--------------------------+");
                Console.WriteLine(sb);
                string choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        BaseInventory ecogame = new Economicgames();
                        ecogame.AddInventry();
                        baseinventory[baseinventory.Length - 1] = ecogame;
                        break;
                    case "2":
                        BaseInventory logicgame = new Logicgames();
                        logicgame.AddInventry();
                        baseinventory[baseinventory.Length - 1] = logicgame;
                        break;
                    case "3":
                        BaseInventory Bowls = new Bowls();
                        Bowls.AddInventry();
                        baseinventory[baseinventory.Length - 1] = Bowls;
                        break;
                    case "4":
                        BaseInventory Ping = new Tenis();
                        Ping.AddInventry();
                        baseinventory[baseinventory.Length - 1] = Ping;
                        break;
                    case "5":
                        break;
                }
                break;
            }


        }
    }
}
