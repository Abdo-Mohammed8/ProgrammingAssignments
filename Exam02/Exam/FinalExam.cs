using System;

namespace Exam02
{
    public class FinalExam : Exam
    {
        public FinalExam(Subject subject, int duration) : base(subject, duration) { }

        public override void Start()
        {
            Console.WriteLine($"Final Exam for {Subject.Name} ({Duration} min)\n");
            int score = 0;

            Stopwatch.Start();

            foreach (var q in Questions)
            {
              
                if (!HasTimeLeft())
                {
                    Console.WriteLine("\nTime is up! Exam ended automatically.\n");
                    break;
                }

                q.Show(); 

                if (q.UserAnswer != null && q.UserAnswer.Text == q.RightAnswer.Text)
                    score += q.Mark;

                Console.WriteLine();
            }

            Stopwatch.Stop(); 

            Console.WriteLine($"Final Exam Finished. Score: {score}/{GetTotalMarks()}");
            ShowTime();
        }

        private int GetTotalMarks()
        {
            int total = 0;
            foreach (var q in Questions)
                total += q.Mark;
            return total;
        }
    }
}
