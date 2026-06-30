namespace MasteringCSharp
{
    internal class Question
    {
        public string QuestionText {get; set;}
        public string[] Answers {get; set;}
        public int CorrectAnswersIndex {get; set;}


        public Question(string questionText, string[] answers, int correctAnswerIndex)
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswersIndex = correctAnswerIndex;
        }

        public bool IsCorrectAnswer(int choice)
        {
            return CorrectAnswersIndex == choice;
        }
    }
}