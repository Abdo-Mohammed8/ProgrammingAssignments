using System;

namespace Exam02.Questions
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string body, int mark, string header = "") : base(body, mark, header) { }

        public override void Show()
        {
            Console.WriteLine(ToString());
            foreach (var ans in AnswerList)
                Console.WriteLine(ans.ToString());

            Console.Write("Enter your answer number: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > AnswerList.Count)
                Console.Write("Invalid input, enter a valid choice number: ");
            UserAnswer = AnswerList[choice - 1];
        }
    }
}
