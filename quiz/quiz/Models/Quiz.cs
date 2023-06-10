using System.Collections.Generic;

namespace quiz.Models
{
    public class Quiz
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsQuizStarted { get; set; }
        public List<Question> Questions { get; set; }
        public int ActiveQuestionIndex { get; set; }
        public string ReceivedAnswer { get; set; }
        public int NextQuestionIndex { get; set; }

        public int AnsweredQuestionCount()
        {
            int answeredCount = 0;
            foreach (var question in Questions)
            {
                if (question.DidUserAnswered)
                {
                    answeredCount++;
                }
            }
            return answeredCount;
        }

        public bool LastQuestionUnansweredleft()
        {
            int answeredCount = AnsweredQuestionCount();
            if (answeredCount+1==Questions.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CorrectlyAnsweredQuestionCount()
        {
            int count = 0;
            foreach (Question question in Questions)
            {
                if (question.WasUserAnswerCorrect)
                {
                    count++;
                }
            }
            return count;
        }
        
    }
    public class Question
    {
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }
        public bool DidUserAnswered { get; set; }
        public bool WasUserAnswerCorrect { get; set; }
    }
    public class Answer
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }


}
