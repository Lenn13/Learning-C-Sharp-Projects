using System;
using TicTacToeProgram;


namespace TicTacToeProgram
{
    class Program
    {
        static bool win = false;
        static string PlayerOne = "";
        static string symbolPlayerOne = "X";

        static string PlayerTwo = "";
        static string symbolPlayerTwo = "O";
        static string[] posArr = { " ", " ", " ", " ", " ", " ", " ", " ", " " };


        static void Main(string[] args)
        {
            bool exit = false;
            WelcomeScreen();
            Console.WriteLine($"Welcome {PlayerTwo}! The Game starts...");
            GameLogic(currentPlayer, currentSymbol, win);
            Console.Clear();
            Console.WriteLine("We have a win!");
            while (exit == false)
            {
                Console.WriteLine("If you want to play another time press S. If you want to Exit press E.");
                string playOrExit = Console.ReadLine();
                if (playOrExit == "S")
                {
                    for (int i = 0; i < posArr.Length; i++)
                    {
                        posArr[i] = " ";
                    }
                    GameLogic(currentPlayer, currentSymbol, win);
                    Console.Clear();
                    Console.WriteLine("We have a win!");
                }
                else if (playOrExit == "E")
                    exit = true;
            }
            Environment.Exit(0);



            Console.ReadKey();

        }

        static string currentPlayer = "";
        static string currentSymbol = "";
        static string notCurrentPlayer = "";

        static void Introduction(string currentPlayer, string currentSymbol)
        {


            Random random = new Random();
            int randomNumber = random.Next(0, 3);

            if (randomNumber == 1)
            {
                Console.WriteLine($"Now, it's {currentPlayer}'s turn. Where do you want to set your {currentSymbol}?");
                Console.WriteLine("Valid Options:");
                Console.WriteLine("topLeft | topMiddle | topRight ");
                Console.WriteLine("middleLeft | middleMiddle | middleRight ");
                Console.WriteLine("bottomLeft | bottomMiddle | bottomRight ");
            }
            else
            {
                Console.WriteLine($"{currentPlayer}. Where do you want do set your {currentSymbol}?");
                Console.WriteLine("Valid Options:");
                Console.WriteLine("topLeft | topMiddle | topRight ");
                Console.WriteLine("middleLeft | middleMiddle | middleRight ");
                Console.WriteLine("bottomLeft | bottomMiddle | bottomRight ");
            }
        }

        static void WelcomeScreen()
        {
            Console.WriteLine("Welcome to Tic Tac Toe. Player One enter your name: ");
            PlayerOne = Console.ReadLine();
            Console.WriteLine($"Welcome {PlayerOne}. Player Two enter your name: ");
            PlayerTwo = Console.ReadLine();
        }

        static void GameLogic(string currentPlayer, string currentSymbol, bool win)
        {
            while (win == false)
            {
                Console.Clear();
                currentPlayer = PlayerOne;
                currentSymbol = symbolPlayerOne;

                TicTacToeBoard();
                Introduction(currentPlayer, currentSymbol);
                Console.WriteLine();
                string whereSymbol = Console.ReadLine();     //Player One Input
                                                             //topLeft
                if (whereSymbol == "topLeft")
                {
                    if (posArr[0] == symbolPlayerTwo)
                    {
                        Console.WriteLine("You can't playe you Symbol, there!");
                    }
                    else
                        posArr[0] = symbolPlayerOne;
                }
                //topMiddle
                else if (whereSymbol == "topMiddle")
                {
                    if (posArr[1] == symbolPlayerTwo)
                    {
                        Console.WriteLine("You can't place you Symbol, there!");
                    }
                    else
                        posArr[1] = symbolPlayerOne;
                }
                //topRight
                else if (whereSymbol == "topRight")
                {
                    if (posArr[2] == symbolPlayerTwo)
                    {
                        Console.WriteLine("You can't place you Symbol, there!");
                    }
                    else
                        posArr[2] = symbolPlayerOne;
                }
                //middleLeft
                else if (whereSymbol == "middleMiddle")
                {
                    if (posArr[3] == symbolPlayerTwo)
                    {
                        Console.WriteLine("You can't place you Symbol, there!");
                    }
                    else
                        posArr[3] = symbolPlayerOne;
                }
                //middleMiddle
                else if (whereSymbol == "middleMiddle")
                {
                    if (posArr[4] == symbolPlayerTwo)
                    {
                        Console.WriteLine("You can't place you Symbol, there!");
                    }
                    else
                        posArr[4] = symbolPlayerOne;
                }
                //middleRigth
                else if (whereSymbol == "middleRight")
                {
                    if (posArr[5] == symbolPlayerTwo)
                    {
                        Console.WriteLine("You can't playe you Symbol, there!");
                    }
                    else
                        posArr[5] = symbolPlayerOne;
                }
                //bottomLeft
                else if (whereSymbol == "bottomLeft")
                {
                    if (posArr[6] == symbolPlayerTwo)
                    {
                        Console.WriteLine("You can't playe you Symbol, there!");
                    }
                    else
                        posArr[6] = symbolPlayerOne;
                }
                //bottomMiddle
                else if (whereSymbol == "bottomMiddle")
                {
                    if (posArr[7] == symbolPlayerTwo)
                    {
                        Console.WriteLine("You can't playe you Symbol, there!");
                    }
                    else
                        posArr[7] = symbolPlayerOne;
                }
                //bottomRigth
                else if (whereSymbol == "bottomRigth")
                {
                    if (posArr[8] == symbolPlayerTwo)
                    {
                        Console.WriteLine("You can't playe you Symbol, there!");
                    }
                    else
                        posArr[8] = symbolPlayerOne;
                }

                //check if Player One wins
                if (posArr[0] == symbolPlayerOne && posArr[1] == symbolPlayerOne && posArr[2] == symbolPlayerOne)
                {
                    Console.WriteLine($"{PlayerOne} Wins!");
                    win = true;
                    break;
                }
                if (posArr[3] == symbolPlayerOne && posArr[4] == symbolPlayerOne && posArr[5] == symbolPlayerOne)
                {
                    Console.WriteLine($"{PlayerOne} wins!");
                    win = true;
                    break;
                }
                if (posArr[6] == symbolPlayerOne && posArr[7] == symbolPlayerOne && posArr[8] == symbolPlayerOne)
                {
                    Console.WriteLine($"{PlayerOne} wins!");
                    win = true;
                    break;
                }
                if (posArr[0] == symbolPlayerOne && posArr[3] == symbolPlayerOne && posArr[6] == symbolPlayerOne)
                {
                    Console.WriteLine($"{PlayerOne} wins!");
                    win = true;
                    break;
                }
                if (posArr[1] == symbolPlayerOne && posArr[4] == symbolPlayerOne && posArr[7] == symbolPlayerOne)
                {
                    Console.WriteLine($"{PlayerOne} wins!");
                    win = true;
                    break;
                }
                if (posArr[2] == symbolPlayerOne && posArr[5] == symbolPlayerOne && posArr[8] == symbolPlayerOne)
                {
                    Console.WriteLine($"{PlayerOne} wins!");
                    win = true;
                    break;
                }
                if (posArr[0] == symbolPlayerOne && posArr[4] == symbolPlayerOne && posArr[8] == symbolPlayerOne)
                {
                    Console.WriteLine($"{PlayerOne} wins!");
                    win = true;
                    break;
                }
                if (posArr[2] == symbolPlayerOne && posArr[4] == symbolPlayerOne && posArr[6] == symbolPlayerOne)
                {
                    Console.WriteLine($"{PlayerOne} wins!");
                    win = true;
                    break;
                }


                Console.Clear();
                TicTacToeBoard();



                currentPlayer = PlayerTwo;                      //Switch Players
                currentSymbol = symbolPlayerTwo;

                Introduction(currentPlayer, currentSymbol);

                string whereSymbolTwo = Console.ReadLine();
                //TopLeft
                if (whereSymbolTwo == "topLeft")
                {
                    if (posArr[0] == symbolPlayerOne)
                    {
                        Console.WriteLine("You can't playe your Symbol, there!");
                    }
                    else
                        posArr[0] = symbolPlayerTwo;
                }
                //TopMiddle
                if (whereSymbolTwo == "topMiddle")
                {
                    if (posArr[1] == symbolPlayerOne)
                    {
                        Console.WriteLine("You can't playe your Symbol, there!");
                    }
                    else
                        posArr[1] = symbolPlayerTwo;
                }
                //topRight
                if (whereSymbolTwo == "topRigth")
                {
                    if (posArr[2] == symbolPlayerOne)
                    {
                        Console.WriteLine("You can't playe your Symbol, there!");
                    }
                    else
                        posArr[2] = symbolPlayerTwo;
                }
                //middleLeft
                if (whereSymbolTwo == "middleLeft")
                {
                    if (posArr[3] == symbolPlayerOne)
                    {
                        Console.WriteLine("You can't playe your Symbol, there!");
                    }
                    else
                        posArr[3] = symbolPlayerTwo;
                }
                //middleMiddle
                if (whereSymbolTwo == "middleMiddle")
                {
                    if (posArr[4] == symbolPlayerOne)
                    {
                        Console.WriteLine("You can't playe your Symbol, there!");
                    }
                    else
                        posArr[4] = symbolPlayerTwo;
                }
                //middleRigth
                if (whereSymbolTwo == "middleRigth")
                {
                    if (posArr[5] == symbolPlayerOne)
                    {
                        Console.WriteLine("You can't playe your Symbol, there!");
                    }
                    else
                        posArr[5] = symbolPlayerTwo;
                }
                //bottomLeft
                if (whereSymbolTwo == "bottomLeft")
                {
                    if (posArr[6] == symbolPlayerOne)
                    {
                        Console.WriteLine("You can't playe your Symbol, there!");
                    }
                    else
                        posArr[6] = symbolPlayerTwo;
                }
                //bottomMiddle
                if (whereSymbolTwo == "bottomMiddle")
                {
                    if (posArr[7] == symbolPlayerOne)
                    {
                        Console.WriteLine("You can't playe your Symbol, there!");
                    }
                    else
                        posArr[7] = symbolPlayerTwo;
                }
                //bottomRight
                if (whereSymbolTwo == "bottomRight")
                {
                    if (posArr[8] == symbolPlayerOne)
                    {
                        Console.WriteLine("You can't playe your Symbol, there!");
                    }
                    else
                        posArr[8] = symbolPlayerTwo;
                }


                //is there a win for player two?
                if (posArr[0] == symbolPlayerTwo && posArr[1] == symbolPlayerTwo && posArr[2] == symbolPlayerTwo)
                {
                    Console.WriteLine($"{PlayerTwo} Wins!");
                    win = true;
                    break;
                }
                if (posArr[3] == symbolPlayerTwo && posArr[4] == symbolPlayerTwo && posArr[5] == symbolPlayerTwo)
                {
                    Console.WriteLine($"{PlayerTwo} Wins!");
                    win = true;
                    break;
                }
                if (posArr[6] == symbolPlayerTwo && posArr[7] == symbolPlayerTwo && posArr[8] == symbolPlayerTwo)
                {
                    Console.WriteLine($"{PlayerTwo} Wins!");
                    win = true;
                    break;
                }
                if (posArr[0] == symbolPlayerTwo && posArr[3] == symbolPlayerTwo && posArr[6] == symbolPlayerTwo)
                {
                    Console.WriteLine($"{PlayerTwo} Wins!");
                    win = true;
                    break;
                }
                if (posArr[1] == symbolPlayerTwo && posArr[4] == symbolPlayerTwo && posArr[7] == symbolPlayerTwo)
                {
                    Console.WriteLine($"{PlayerTwo} Wins!");
                    win = true;
                    break;
                }
                if (posArr[2] == symbolPlayerTwo && posArr[5] == symbolPlayerTwo && posArr[8] == symbolPlayerTwo)
                {
                    Console.WriteLine($"{PlayerTwo} Wins!");
                    win = true;
                    break;
                }
                if (posArr[0] == symbolPlayerTwo && posArr[4] == symbolPlayerTwo && posArr[8] == symbolPlayerTwo)
                {
                    Console.WriteLine($"{PlayerTwo} Wins!");
                    win = true;
                    break;
                }
                if (posArr[2] == symbolPlayerTwo && posArr[4] == symbolPlayerTwo && posArr[6] == symbolPlayerTwo)
                {
                    Console.WriteLine($"{PlayerTwo} Wins!");
                    win = true;
                    break;
                }
            }
        }

        //TicTacToe Game Board
        static void TicTacToeBoard()
        {
            Console.WriteLine("TicTacToe-GameBoard:\n");
            Console.WriteLine($"╔═══╦═══╦═══╗");
            Console.WriteLine($"║ {posArr[0]} ║ {posArr[1]} ║ {posArr[2]} ║");
            Console.WriteLine($"╠═══╬═══╬═══╣");
            Console.WriteLine($"║ {posArr[3]} ║ {posArr[4]} ║ {posArr[5]} ║");
            Console.WriteLine($"╠═══╬═══╬═══╣");
            Console.WriteLine($"║ {posArr[6]} ║ {posArr[7]} ║ {posArr[8]} ║");
            Console.WriteLine($"╚═══╩═══╩═══╝");
            Console.WriteLine();
        }

    }
}