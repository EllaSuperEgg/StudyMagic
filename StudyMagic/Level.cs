using System;
using System.IO;

namespace StudyMagic
{
    public class Level
    {
        //string input;
        //string[] Term;
        //string[] Definition;
        //int PlayerPoints;
        //public string[] Terms =new string [2];
        //Term String = new Term("String", "A string of characters", 1);
        //Term Integer = new Term("Integer", "A whole numbers", 1);
        //Term Boolean = new Term("Boolean", "True or false", 1);
        //Term Class = new Term("Class", "An extensible program-code-template for creating objects, providing initial values for state (member variables) and implementations of behavior (member functions or methods)", 2);
        //Term Object = new Term("Object", "a particular instance of a class, which can be a combination of variables, functions, and data structures.", 2);
        //Term Void = new Term("Void", "A return type that will not return anything", 2);

        static string[] wordList1 = new string[] { "string", "integer", "boolean", "assignment", "method" };
        static string[] definitionList1 = new string[] { "A string of characters", "A whole numbers", "True or false", "a operator used to assign a new value to a variable,property,event or indexer elements", " a code block that contains a series of statements" };
        static string[] wordList2 = new string[] { "array", "private", "public", "void", "conditional statement", "increment", "while loop", "for loop", "switch", "concatenation", "class", "object", "identifier", "keyword", "array index number" };
        static string[] definitionList2 = new string[]{"a data structure that contains a number of variables that are accessed through computed indices",
            "A keyword used to declare the method or variable is accessible from derived types in its containing assembly only if the static type of the variable is the derived class type",
            "a keyword used to declare the accessibility of a type and type member such that the access is not limited",
            "a return type for a method that specifies that the method doesn't return a value",
            "A statement that can be executed based on a condition,like if-else statement",
            "an unary operator represented by the symbols \"+\" which will increment the value of its operand by one",
            "a statement executes a statement or a block of statements while a specified boolean expression evaluates to true",
           "a loop executes a block of statements repeatedly until the specified condition returns false.",
          "a selection statement that chooses a single switch section to execute from a list of candidates based on a pattern match with the match expression",
          "the operation of joining character strings end-to-end",
          "An extensible program-code-template for creating objects, providing initial values for state (member variables) and implementations of behavior (member functions or methods)",
          "providing initial values for state (member variables) and implementations of behavior (member functions or methods)",
          "the user-defined name of a program element",
          "Keywords are predefined, reserved identifiers that have special meanings to the compiler",
          "the index of a string in an array"};


        public Level(string[] term, string[] definition, int points)
        {
            string LevelOneWordFile = "/Users/ella/Desktop/StudyApplication_mluo1007/StudyMagic/StudyMagic/bin/Debug/leveloneworddata.txt";
            string LevelOneDefinitionFile = "/Users/ella/Desktop/StudyApplication_mluo1007/StudyMagic/StudyMagic/bin/Debug/levelonedefinitiondata.txt";
            string LevelTwoWordFile = "/Users/ella/Desktop/StudyApplication_mluo1007/StudyMagic/StudyMagic/bin/Debug/leveltwoworddata.txt";
            string LevelTwoDefinitionFile = "/Users/ella/Desktop/StudyApplication_mluo1007/StudyMagic/StudyMagic/bin/Debug/leveltwodefinitiondata.txt";

            File.WriteAllLines(LevelOneWordFile, wordList1);
            File.WriteAllLines(LevelOneDefinitionFile, definitionList1);
            File.WriteAllLines(LevelTwoWordFile, wordList2);
            File.WriteAllLines(LevelTwoDefinitionFile, definitionList2);

        }


    }
}
