using System;

namespace Exam02
{
    public class PracticalExam : Exam
    {
        public PracticalExam(Subject subject, int duration) : base(subject, duration) { }

        public override void Start()
        {
            Console.WriteLine($"Practical Exam for {Subject.Name} ({Duration} min)\n");

            Stopwatch.Start();

            foreach (var q in Questions)
            {
                if (!HasTimeLeft())
                {
                    Console.WriteLine("\nTime is up! Exam ended automatically.\n");
                    break;
                }

                q.Show();
                Console.WriteLine($"Right Answer: {q.RightAnswer.Text}\n");
            }

            Stopwatch.Stop();

            Console.WriteLine("Practical Exam Finished.");
            ShowTime();
        }
    }
}
