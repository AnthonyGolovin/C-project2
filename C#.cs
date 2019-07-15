using System;
using System.Collections.Generic;

class Riddle
{
    List<string> stuff = new List<string> {};

    static void Randomizer()
    {
        for (int i = 0; i < 3; i++)
        {
            Random rand = new Random();
            int currentRiddle = rand.Next(1, riddles.Count);
        }
    }
  static void Main()
  {
      Console.WriteLine("Solve the Spinx's riddle and you may live");
      string q1 = "You own a one story house with a car and kids in a world where everything that exists is red. All that exists in your house is red except the stairs, why?";
      Console.WriteLine(q1);
      string answer = Console.ReadLine();
      if (answer == "There are no stairs") {
          Console.WriteLine("Congrats you have solved the riddle");
          Riddle2();
      } else {
          Console.WriteLine("You have answered incorrectly, and as a result you have been eaten");
      }
  }
  static void Riddle2()
  {
      Console.WriteLine("Hmmm, heres a good riddle");
      string q2 = "Duck....duck.....duck?";
      Console.WriteLine(q2);
      string answer = Console.ReadLine();
      if (answer == "Goose") {
          Console.WriteLine("You solved it, but I am unimpressed");
          Riddle3();
      } else {
          Console.WriteLine("You have answered incorrectly, and as a result you have been eaten");
      }
  }
  static void Riddle3()
  {
      Console.WriteLine("Psst kid, want some riddles?");
      string q3 = "How much could a wood chuck chuck if a wood chuck could chuck wood";
      Console.WriteLine(q3);
      string answer = Console.ReadLine();
      if (answer == "About 7") {
          Console.WriteLine("You cheated, niceeeeee");
      } else {
          Console.WriteLine("You have answered incorrectly, and as a result you have been eaten");
      }
  }
}
// using System;
// using System.Collections.Generic;

// class Riddle
// {
//     public static Dictionary<string, string> differentRiddles = new Dictionary<string, string>();

//     static void Randomizer()
//     {
       
//     }
//   static void Main()
//   {
//   riddle1 = Console.WriteLine("you own a one story house with a car and kids in a world where everything that exists is red. All that exists in your house is red except the stairs, why?");
//   riddle2 = Console.WriteLine("Duck....duck.....duck?");
//   riddle3 = Console.WriteLine("How much could a wood chuck chuck if a wood chuck could chuck wood");
//   }
//    static void UserAnswer()
//   {
//    int answer1 = Console.ReadLine();
//    int answer2 = Console.ReadLine();
//    int answer3 = Console.ReadLine();
//   }
//     static void AnswerCheck()
//     {
//         if (answer1 == "There are no stairs") {
//             Console.WriteLine("Congrats you have solved the riddle");
//         } else {
//             Console.WriteLine("You have answered incorrectly, and as a result you have been eaten");
//         }
//     }
// }