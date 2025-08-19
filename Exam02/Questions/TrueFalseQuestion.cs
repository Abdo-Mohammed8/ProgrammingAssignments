using System;

namespace Exam02.Questions
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string body, int mark, string header = "") : base(body, mark, header)
        {
            AnswerList.Add(new Answer(1, "True"));
            AnswerList.Add(new Answer(2, "False"));
        }

        public override void Show()
        {
            Console.WriteLine(ToString());
            foreach (var ans in AnswerList)
                Console.WriteLine(ans.ToString());

            Console.Write("Enter your answer (1 for True, 2 for False): ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice != 1 && choice != 2)
                Console.Write("Invalid input, enter 1 or 2: ");
            UserAnswer = AnswerList[choice - 1];
        }
    }
}
