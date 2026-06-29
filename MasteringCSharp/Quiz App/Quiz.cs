namespace MyApplication
{
    internal class Quiz
    {
        private Question[] _questions;
        private int _score;
        public Quiz(Question[] questions)
        {
            this._questions = questions;
            this._score = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the quiz!");
            int questionNumber = 1;

            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct!");
                    _score++;
                } else
                {
                    Console.WriteLine($"Too bad, the answer is {question.Answers[question.CorrectAnswersIndex]}");
                }
            }
            DisplayResults();
        }

       private void DisplayResults()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Results                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();


            Console.WriteLine($"Quiz finished. Your score is: {_score} out of {_questions.Length}");

            double percentage = (double) _score / _questions.Length;
            if(percentage >= 0.8)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Excellent Work!");
            }else if(percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good effort!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep practicing");
            }
            Console.ResetColor ();
        }

        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Question                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.ResetColor();
                Console.WriteLine($"{i + 1}. {question.Answers[i]}");
            }
        }

        private int GetUserChoice()
        {
            Console.WriteLine("Choose your answer from 1 - 4: ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invald choice. Enter a valid number");
                input = Console.ReadLine();
            }
            return choice - 1;
        }
    }
}