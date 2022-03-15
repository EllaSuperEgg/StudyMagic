using System;
namespace StudyMagic
{
    public class Player
    {
        public string PlayerName;
        public int PlayerLevel;
        public int Points=0;
        //string input;
        //string playerName;
       
       

        public Player(int playerLevel)
        {
            
            Console.WriteLine("Please choose a wizard name.");
            PlayerName = Console.ReadLine();
            Console.WriteLine("Hi " + PlayerName);
            PlayerLevel = playerLevel;
            Points = 0;
        }

        //public void Playerlevel()
        //{
        //    Console.WriteLine("What is your magic level? Please enter 1 or 2(if you are new please enter \"1\"");
        //    input = Console.ReadLine();
        //    if (input == "1")
        //    {
        //        Console.WriteLine("I am glad you are here NewBie magician!");
        //        PlayerLevel = 1;
        //
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ready for new adventure Junior Magician? ");
        //        PlayerLevel = 2;
        //    }
        //
        //    Console.WriteLine("You initiate magician energy point: 0 ");
        //    Console.WriteLine("Press Enter to continue.");
        //    Console.ReadKey();
        //    Console.Clear();
        //}


        //private void Review();

        //private void Test();

    }
}


