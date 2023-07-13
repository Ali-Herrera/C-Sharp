using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      string[] questions = {"Are cats the best house pet?", "Are there four fingers on a hand?", "is having two cats better than one?"};

      bool[] answers = {true, false, true};

      bool[] responses = new bool[questions.Length];

      if(questions.Length != answers.Length)
      {
        Console.WriteLine("arrays are not equal in length");
      }

      int askingIndex = 0;

      foreach (string question in questions)
      {
        string input;
        bool isBool;
        bool inputBool;

        Console.WriteLine(question, "true or false?");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);

        while (isBool != true)
        {
          Console.WriteLine("Please respond with 'true' or 'false'");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
        }

        responses[askingIndex] = isBool;
        askingIndex++;
      }

     int scoringIndex = 0;
     int score = 0;
     foreach(bool answer in answers)
     {
       bool response = responses[scoringIndex];
       Console.Write(scoringIndex + 1 + ".");
       Console.WriteLine($"Input: {response} | Answer: {answer}");
       if (response == answer)
       {
         score++;
       }
       scoringIndex++;
     }
     Console.WriteLine($"You got {score} out of 3 correct!");

    }
  }
}
