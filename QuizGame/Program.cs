using System;
using System.Net.NetworkInformation;

namespace QuizGame
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Quiz Game");
      Console.WriteLine("*************************");

      string[] questions = new string[3] {
        "1. What is the capital of Italy?",
        "2. What is the red planet?",
        "3. What is the largest animal"
      };
      string[] answers = new string[3] { "Rome", "Mars", "Whale" };
      byte score = 0;

      for (int i = 0; i < questions.Length; i++)
      {
        Console.WriteLine(questions[i]);

        string answer = Console.ReadLine();
        try
        {
          bool result = IsAnswerCorrect(answers[i], answer);
          if (result)
          {
            Console.WriteLine("Correct Answer !");
            score++;
          }
          else
          {
            Console.WriteLine($"Sorry, incorrect answer. The correct answer is {answers[i]}");
          }
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
        }
      }
      Console.WriteLine($"\nYour Score is {score} of {questions.Length}");
      Console.WriteLine("\n\nThanks for joining the quiz! See you next time!");
    }
    private static bool IsAnswerCorrect(string correctAnswer, string userAnswer)
    {
      if (string.IsNullOrEmpty(userAnswer))
      {
        throw new Exception("Answer Can't be Empty");
      }
      return correctAnswer.ToLower() == userAnswer.ToLower();
    }
  }
}
