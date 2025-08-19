using Exam02;
using Exam02.Questions;
using System;

class Program
{
    static void Main()
    {

        Console.Write("Enter Subject Id: ");
        int subjectId;
        while (!int.TryParse(Console.ReadLine(), out subjectId))
        {
            Console.Write("Invalid input. Enter a positive number: ");
        }

        Console.Write("Enter Subject Name: ");
        string subjectName = Console.ReadLine();
        Subject subject = new Subject(subjectId, subjectName);

        Console.Write("Enter Exam Type (1. Final, 2. Practical): ");
        int examType;
        while (!int.TryParse(Console.ReadLine(), out examType) || (examType != 1 && examType != 2))
        {
            Console.Write("Invalid input, enter 1 for Final or 2 for Practical: ");
        }

        Console.Write("Enter Exam Duration (minutes): ");
        int duration;
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.Write("Invalid input, enter a positive number: ");
        }

        Exam exam = (examType == 1) ? new FinalExam(subject, duration) : new PracticalExam(subject, duration);
        subject.CreateExam(exam);

        Console.Write("How many questions? ");
        int qCount;
        while (!int.TryParse(Console.ReadLine(), out qCount) || qCount <= 0)
        {
            Console.Write("Invalid input, enter a positive number: ");
        }

        for (int i = 0; i < qCount; i++)
        {
            Console.WriteLine($"\nQuestion {i + 1}:");

            Console.Write("Enter Question Type (1. MCQ, 2. True/False): ");
            int type;
            while (!int.TryParse(Console.ReadLine(), out type) || (type != 1 && type != 2))
            {
                Console.Write("Invalid input, enter 1 for MCQ or 2 for True/False: ");
            }

            Console.Write("Enter Question Body: ");
            string body = Console.ReadLine();

            Console.Write("Enter Question Mark: ");
            int mark;
            while (!int.TryParse(Console.ReadLine(), out mark) || mark <= 0)
            {
                Console.Write("Invalid input, enter a positive number: ");
            }

            Question q;
            if (type == 1)
            {
                q = new MCQQuestion(body, mark);
                Console.Write("How many choices? ");
                int choiceCount;
                while (!int.TryParse(Console.ReadLine(), out choiceCount) || choiceCount < 2)
                    Console.Write("Enter number >=2: ");

                for (int j = 0; j < choiceCount; j++)
                {
                    Console.Write($"Enter choice {j + 1}: ");
                    string ans = Console.ReadLine();
                    q.AnswerList.Add(new Answer(j + 1, ans));
                }

                Console.Write("Enter Right Answer Number: ");
                int right;
                while (!int.TryParse(Console.ReadLine(), out right) || right < 1 || right > choiceCount)
                    Console.Write($"Enter number between 1 and {choiceCount}: ");
                q.RightAnswer = q.AnswerList[right - 1];
            }
            else
            {
                q = new TrueFalseQuestion(body, mark);
                Console.Write("Enter Right Answer (1 for True, 2 for False): ");
                int right;
                while (!int.TryParse(Console.ReadLine(), out right) || (right != 1 && right != 2))
                    Console.Write("Enter 1 or 2: ");
                q.RightAnswer = q.AnswerList[right - 1];
            }

            exam.Questions.Add(q);
        }


        Console.Write("\nDo you want to start the exam? (y/n): ");
        if (Console.ReadLine().ToLower() == "y")
        {
            Console.Clear();
            exam.Start();
        }
        else
        {
            Console.WriteLine("Exam Cancelled.");
        }
    }
}
