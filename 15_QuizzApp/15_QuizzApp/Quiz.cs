using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_QuizzApp
{
    internal class Quiz
    {
        private Question[] questions;
        private int score;

        public Quiz(Question[] questions)
        {
            this.questions = questions;
            score = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the quiz!");
            int questionNumber = 1;

            foreach (Question question in questions)
            {
                Console.WriteLine($"Question {questionNumber++}: ");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong lmao! The correct answer would be {question.Answers[question.CorrectAnswerIndex]}");
                }
            } 
            DisplayResults();   
        }

        private void DisplayResults()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n                |______________________________________|");
            Console.WriteLine("                 |               Results                |");
            Console.WriteLine("                  |______________________________________|\n\n");
            Console.ResetColor();

            Console.WriteLine($"Quiz finished. Your score is {score} out of {questions.Length}");

            double percentage = (double)score / questions.Length;
            if (percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent work.");
            }
            else if (percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Meh");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("bruh");
            }
            Console.ResetColor();
        }

        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n                |______________________________________|");
            Console.WriteLine("                 |               Question               |");
            Console.WriteLine("                  |______________________________________|\n\n");
            Console.ResetColor();


            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan; // Changes the text color
                Console.Write("   ");
                Console.Write(i + 1);
                Console.ResetColor(); // Resets the console color

                Console.WriteLine($". {question.Answers[i]}");
            }

        }

        private int GetUserChoice()
        {
            Console.WriteLine("Your answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > questions[0].Answers.Length) 
            {
                Console.WriteLine($"Invalid choice. Please enter a number between 1 and {questions[0].Answers.Length}");
                input = Console.ReadLine();
            }
            return choice - 1;

        }
    }

}
