using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1
{
    // ={"BENG100", "COMP213","COMM123","PSYC200"};
    internal class Questions
    {
        public const int SIZE = 3;
        public const int NUMBEROFQUESTIONS = 4;
        public int questionCount = 0;
        public int resultsScore = 0;
        public Questions(string question, string[] answers, string correctAnswer)
        {
            Question = question;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }
        public string? Question { get; set; }
        public string[]? Answers { get; set; }
        public string? CorrectAnswer { get; set; }

        Random rnd = new Random();

        public void choiceShuffle()
        {
            Answers = Answers.OrderBy(x => rnd.Next()).ToArray();
        }

    }
}

