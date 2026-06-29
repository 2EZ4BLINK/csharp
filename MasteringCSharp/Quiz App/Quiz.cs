namespace MyApplication
{
    internal class Quiz
    {
        private Question[] questions;

        public Quiz(Question[] questions)
        {
            this.questions = questions;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the quiz!");
            int questionNumber = 1;

            foreach (Question question in questions)
            {
                Console.WriteLine($"Question {questionNumber++}");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct!");
                } else
                {
                    Console.WriteLine($"Too bad, the answer is {question.Answers[question.CorrectAnswersIndex]}");
                }
            }
            
        }

        private void DisplayQuestion(Question question)
        {
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Question                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine(question.QuestionText);
            for (int i = 0; i < question.Answers.Length; i++)
            {
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