using System;
using System.IO;

namespace Hangman
{
    class Programm
    {
        static int wins = 0;
        static int lost = 0;
        static int lives = 0;
        static string minus = "";
        static string currentWord = "";
        static string player = "";
        static string readWords = File.ReadAllText(@"D:\HangmanWords\words.txt");
        static string[] guessingWords = readWords.Split(',');
        static char guessingCharacter = ' ';
        static List<char> enteredCharacters = new List<char>();
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            player = Console.ReadLine();
            Console.Clear();

            GameLogic();
            while (true)
            {
                var userInput = "";

                Console.WriteLine("If you want to play another time press S else press E or press I to save your score");
                while(true)
                {
                    try
                    {
                        userInput = Console.ReadLine();
                    }catch(FormatException)
                    {
                        Console.WriteLine("Wrong format try another time");
                    }
                    break;
                }
                if (userInput == "S")
                {
                    Console.Clear();
                    GameLogic();
                }
                else if(userInput == "I")
                {
                    SaveScore();
                    Console.Clear();
                }
                else
                    Environment.Exit(0);


            }
        }

        static void GameLogic()
        {
            int maxLength = guessingWords.Length;
            var random = new Random();

            int currentIndex = random.Next(0, maxLength);
            currentWord = guessingWords[currentIndex];
            lives = currentWord.Length + 6;
            for (int i = 0; i < currentWord.Length; i++)
                minus += "_";

            while (true)
            {
                if (!minus.Contains('_'))
                {
                    wins++;
                    Console.WriteLine("You won!");
                    Console.ReadKey();
                    break;
                }
                else if (lives <= 0)
                {
                    lost++;
                    Console.WriteLine("You lost :(");
                    Console.WriteLine($"The word was: {currentWord}");
                    Console.ReadKey();
                    break;
                }


                foreach (var enteredChar in enteredCharacters)
                    Console.Write(enteredChar + ", ");

                Console.WriteLine();

                Console.WriteLine(minus);
                
                Console.Write("Lives:");
                for (int i = 0;i < lives;i++)
                {
                    Console.Write("x");
                }

                Console.WriteLine();

                while (true)
                {
                    Console.Write("Enter your guessing character: ");
                    try
                    {
                        while(true)
                        {
                            guessingCharacter = Convert.ToChar(Console.ReadLine());
                            if (enteredCharacters.Contains(guessingCharacter))
                                Console.WriteLine("You also entered that Character!");
                            else
                                break;
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(@"You can only enter a letter like U, X or something like that NOT 5 or % ");
                        continue;
                    }
                    break;
                }

                int indexOfWord = currentWord.IndexOf(guessingCharacter, StringComparison.CurrentCultureIgnoreCase);
                int lastIndexOf = currentWord.LastIndexOf(guessingCharacter.ToString(), StringComparison.CurrentCultureIgnoreCase);
                if (currentWord.Contains(guessingCharacter.ToString().ToUpper()) || currentWord.Contains(guessingCharacter.ToString().ToLower()))
                {
                    minus = minus.Remove(indexOfWord, 1).Insert(indexOfWord, guessingCharacter.ToString());
                    minus = minus.Remove(lastIndexOf, 1).Insert(lastIndexOf, guessingCharacter.ToString());
                }
                else
                {
                    lives--;
                    enteredCharacters.Add(guessingCharacter);
                }


                Console.WriteLine(lives);

                Console.Clear();
            }

            Console.Clear();
            currentWord = "";
            minus = "";
        }
        static void SaveScore()
        {
            string content = $"Your wins: {wins}, Your losts: {lost}, Your entered player name: {player}.";
            Console.Clear();
            Console.WriteLine(@"Enter the path of the file, Like D:\likePath\likeFolder\ Make sure that at the end there is a \");
            string path = Console.ReadLine();
            string fileCreate = path + "score.txt";

            while (true)
            {
                try
                {
                    if (!File.Exists(fileCreate))
                    {
                        File.Create(fileCreate);
                        File.WriteAllText(fileCreate, content);
                    }
                    else
                        File.WriteAllText(fileCreate, content);
                }
                catch (Exception)
                {
                    Console.WriteLine(@"The path is maybe not correct or the acces is denied. Make sure you enter a path like D:\score.txt");
                }
                break;
            }
            Console.WriteLine("Succesfully Saved :D");
            Environment.Exit(0);
        }
    }
}