using System;
using System.IO;

namespace StudyMagic
{
    public class Game
    {
        //Level[] Levels = new Level[2];
        //why cant I put it here?

        //Level Two = new Level(wordList2, definitionList2, playerPoints);
        //static string[] wordList1 = new string[] { "string", "integer", "boolean", "assignment", "method" };
        //static string[] definitionList1 = new string[] { "A string of characters", "A whole numbers", "True or false", "a operator used to assign a new value to a variable,property,event or indexer elements", " a code block that contains a series of statements" };
        //static string[] wordList2 = new string[] { "array", "private", "public", "void", "conditional statement","increment","while loop","for loop","switch","concatenation","class","object","identifier","keyword","array index number"};
        //static string[] definitionList2 = new string[]{"a data structure that contains a number of variables that are accessed through computed indices",
        //    "A keyword used to declare the method or variable is accessible from derived types in its containing assembly only if the static type of the variable is the derived class type",
        //    "a keyword used to declare the accessibility of a type and type member such that the access is not limited",
        //    "a return type for a method that specifies that the method doesn't return a value",
        //    "A statement that can be executed based on a condition,like if-else statement",
        //    "an unary operator represented by the symbols \"+\" which will increment the value of its operand by one",
        //    "a statement executes a statement or a block of statements while a specified boolean expression evaluates to true",
        //   "a loop executes a block of statements repeatedly until the specified condition returns false.",
        //  "a selection statement that chooses a single switch section to execute from a list of candidates based on a pattern match with the match expression",
        //  "the operation of joining character strings end-to-end",
        //  "An extensible program-code-template for creating objects, providing initial values for state (member variables) and implementations of behavior (member functions or methods)",
        //  "providing initial values for state (member variables) and implementations of behavior (member functions or methods)", 
        // "the user-defined name of a program element", 
        // "Keywords are predefined, reserved identifiers that have special meanings to the compiler", 
        // "the index of a string in an array"};


        static string[] wordList1 = new string[5];
        static string[] definitionList1 = new string[5];
        static string[] wordList2 = new string[15];
        static string[] definitionList2 = new string[15];
        
        string[] passWordList = new string[15];
            //definitionList2[1] = "a data structure that contains a number of variables that are accessed through computed indices" ;
        //definitionList2[2] = "A private protected member of a base class is accessible from derived types in its containing assembly only if the static type of the variable is the derived class type."
        string playerName;
        int playerLevel;
        int playerPoints;

        Random random = new Random();


        public Game()
        {
            ReadFile();

            //Console Title and Author Name
            Console.Title = "StudyMagic by Ella Luo";
            //Welcome player and introduce the game
            Console.Write("Hi! Welcome to the ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("StudyMagic!");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("We are going to help you review the terms in programming!");
            Console.ResetColor();
            Console.WriteLine("And make you into a wizard.");


            //Ask for player name and level.
            Console.WriteLine("Please enter your wizard name");
            playerName = Console.ReadLine();
              Console.WriteLine("What is your magic level? Please enter 1 or 2(if you are new please enter \"1\"");
            playerLevel = Convert.ToInt32(Console.ReadLine());
            if (playerLevel == 1)
            {
                Level One = new Level(wordList1, definitionList1, playerPoints);
                Console.WriteLine("Welcome NewBie Magician! Are you ready for today's review?");
                Console.WriteLine("Press Enter to Continue...");
                Console.ReadKey();
                Console.Clear();
                Review1();
                TestHeading();
                Test1();



            }

            else
            {
                Level Two = new Level(wordList2, definitionList2, playerPoints);
                Console.WriteLine("Welcome back Junior Magician! Are you ready for today's review?");
                Console.WriteLine("Press Enter to Continue...");
                Console.ReadKey();
                Console.Clear();
                Review2();
                TestHeading();
                Test2();

            }
            Console.WriteLine("Press enter to exit.");
            Console.ReadKey();
        }


        void Review1()
        {
            Console.WriteLine("This is your magic list today:");
            for (int i = 0; i < wordList1.Length; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0} {1}:{2}\n", i + 1, wordList1[i], definitionList1[i]);
            }
            Console.ResetColor();
            Console.WriteLine("The chief wizard opened the test to Junior Wizard just now. Are you ready?");
            Console.WriteLine("Press Enter to enter test");
            Console.ReadKey();
            Console.Clear();
        }

        void ReadFile()
        {
            //DirectoryInfo currDir = new DirectoryInfo(".");
            //Console.WriteLine(currDir.FullName);
            string LevelOneWordFile = "/Users/ella/Desktop/StudyApplication_mluo1007/StudyMagic/StudyMagic/bin/Debug/leveloneworddata.txt";
            string LevelOneDefinitionFile = "/Users/ella/Desktop/StudyApplication_mluo1007/StudyMagic/StudyMagic/bin/Debug/levelonedefinitiondata.txt";
            string LevelTwoWordFile = "/Users/ella/Desktop/StudyApplication_mluo1007/StudyMagic/StudyMagic/bin/Debug/leveltwoworddata.txt";
            string LevelTwoDefinitionFile = "/Users/ella/Desktop/StudyApplication_mluo1007/StudyMagic/StudyMagic/bin/Debug/leveltwodefinitiondata.txt";

            //File.WriteAllLines(LevelOneWordFile, wordList1);
            //File.WriteAllLines(LevelOneDefinitionFile, definitionList1);
            //File.WriteAllLines(LevelTwoWordFile, wordList2);
            //File.WriteAllLines(LevelTwoDefinitionFile, definitionList2);

            if (File.Exists(LevelOneWordFile))
            {
                wordList1 = File.ReadAllLines(LevelOneWordFile);
                definitionList1 = File.ReadAllLines(LevelOneDefinitionFile);
            }

            if (File.Exists(LevelTwoWordFile))
            {
                wordList2 = File.ReadAllLines(LevelTwoWordFile);
                definitionList2 = File.ReadAllLines(LevelTwoDefinitionFile);
            }


            //File.WriteAllLines(PlayerData, passWordList);
        }
        void Review2()
        {
            Console.WriteLine("This is the Junior magic word list:");
            for (int i = 0; i < wordList2.Length; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("  {0,-3:00} {1}:{2}", i + 1, wordList2[i], definitionList2[i]);
                Console.ResetColor();
                Console.WriteLine("\n\n\n");
            }
            Console.ResetColor();
            Console.WriteLine("The Senior Wizard Test was opened just for you. Are you ready, Junior Magician?");
            Console.WriteLine("Press Enter to enter test");
            Console.ReadKey();
            Console.Clear();
        }
        void TestHeading()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=============================================================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("    " + playerName);
            Console.ResetColor();
            Console.Write(" :: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Level: " + playerLevel);
            Console.ResetColor();
            Console.Write(" :: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("points: " + playerPoints);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n=============================================================");
            Console.ResetColor();
            Console.WriteLine("Magic time! Match the right term to its definition!");
            Console.WriteLine("Please write the term name to the definition below.");

        }

        void Test1()
        {
            int index;

            //select words that didn't passed.
            do
            {

                index = random.Next(definitionList1.Length);
            }
            while (wordList1[index] == passWordList[index]);

            string definition = definitionList1[index];
            Console.WriteLine("\n\n\n\n"+definition + ":");

            string answer = Console.ReadLine().ToLower();
            if (answer == wordList1[index])
            {
                Console.WriteLine("Correct! You get one magic point!");
                passWordList[index] = wordList1[index];
                playerPoints = playerPoints + 1;
                Console.WriteLine("Press Enter to match more magic words");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Oops... maybe try again? ");
                Console.WriteLine("The correct answer is {0}. Your answer is {1}. ", wordList1[index],answer);

            }

            TestHeading();
            if (playerPoints<5)
            {
                Test1();
            }

            else
            {
                Upgrade();
            }
        }

void Upgrade()
        {
            Console.WriteLine("Correct! Congratulations! You pass the first test!");
            Console.WriteLine("Only people with dedication could achieve the height of Junior magician!");
            Console.WriteLine("Are you ready for more? (Press enter to continue)");
            Console.ReadKey();
            Review2();
            Test2();
        }

        void Test2()
        {
            int index;

            //select words that didn't passed.
            do
            {

                index = random.Next(definitionList2.Length);
            }
            while (wordList2[index] == passWordList[index]);

            string definition = definitionList2[index];

            Console.WriteLine(definition + ":");

            string answer = Console.ReadLine().ToLower();

            if (answer == wordList2[index])
            {
                Console.WriteLine("Correct!");
                passWordList[index] = wordList2[index];
                playerPoints = playerPoints + 1;
                TestHeading();
            }

            else
            {
                Console.WriteLine("Wrong Answer.Try again wizard!");
                TestHeading();
            }



            if (playerPoints < 15)
            {
                Test2();
            }

            else
            {
                Congratulation();
            }
        }

public void  Congratulation()
        {
            Console.WriteLine ("Congratualtion! You passed all the tricky wizard test and YOU ARE A REAL WIZARD now!!!\n"  +
                    "Here is your senior wizard magic wand!\n" + @"
────▗▖────────▗▖────────▗▖────
─────▀▚──────▟██▖─────▗▛▘─────
────────────▟████▖────────────
─────▀█████████████████▀──────
─▀▜▄▖───▀████████████▀▘───▗▄▖─
──────────████████▛▘────▝▀▘───
────────▄██████████▖──────────
───────▟████▀─▌▜████──────────
─────▗▟█▀▀────▌─▝▀███▖──▖─────
─▗▟▘─▝────────▌─────▀▀──▝▙▖───
─▀────────────▌───────────▀───
──────────────▌───────────────
──────────────▌───────────────
──────────────▌───────────────
──────────────────────────────
");
            
        }

    }
}

//Got help from Iran in the 916 lab for syntax mistakes.
//Got idea from Shuaib Ahmed about the random code.
//Final magic wand graphic is from TheNerdShow.com.
