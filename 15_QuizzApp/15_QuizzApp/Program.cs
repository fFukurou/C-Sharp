namespace _15_QuizzApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question("What is the capital of Japan?", // Question Text
                new string[] {"Kyoto", "Fukushima", "Tokyo", "Shibuya", "Hiroshima"}, // Answers
                2), // Correct Answer

                new Question("Which of the following games won Game Of The Year on 2023?",
                new string[] {"Baldur's Gate III", "God of War Ragnarok", "Diablo IV (lmao1!)", "Ghost of Tsushima", "Elden Ring: Shadow of the Erdtree"},
                0),

                new Question("Which anime is the best one? (Not a subjective question)",
                new string[] {"One Piece", "Naruto", "Frieren", "Evangelion", "Shingeki no Kyojin"},
                4),
                
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();

        }
    }
}
