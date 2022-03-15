using System;
namespace Application
{
    public class Terms
    {
        public string Word;
        public string definition;
        public int points;
        public int level;

        static public void Terms(string word, string definition, int level)
        {
            Word = word;
            Definition = definition;
            Points = 1;
            level = level;e

            Terms01 = new Terms("String", "A string of characters", 1);
            Terms02 = new Terms("Integer", "A whole numbers", 1);
            Terms03 = new Terms("Boolean", "True or false", 1);
            Terms04 = new Terms("Class", "An extensible program-code-template for creating objects, providing initial values for state (member variables) and implementations of behavior (member functions or methods)", 2);
            Terms05 = new Terms("Object", "a particular instance of a class, which can be a combination of variables, functions, and data structures.", 2);

            Console.WriteLine(Terms01.Word);
            
        }

        static public void ShowTerms()
        {
            if (Player.PlayerName = 1)
            {
                Console.WriteLine("01 " + Terms01.Word + ": " + Term01.Definition);
                Console.WriteLine("02 " + Terms02.Word + ": " + Term02.Definition);
                Console.WriteLine("03 " + Terms03.Word + ": " + Term03.Definition);
            }

        }
    }
}
