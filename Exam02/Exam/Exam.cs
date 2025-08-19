using Exam02.Questions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Exam02
{
    public abstract class Exam
    {
        public Subject Subject { get; set; }
        public int Duration { get; set; } 
        public List<Question> Questions { get; set; }
        protected Stopwatch Stopwatch { get; set; }

        public Exam(Subject subject, int duration)
        {
            Subject = subject;
            Duration = duration;
            Questions = new List<Question>();
            Stopwatch = new Stopwatch();
        }

        public abstract void Start();

        protected void ShowTime()
        {
            Console.WriteLine($"Time Taken: {Stopwatch.Elapsed.Minutes} minutes {Stopwatch.Elapsed.Seconds} seconds");
        }

       
        protected bool HasTimeLeft()
        {
            return Stopwatch.Elapsed.TotalMinutes < Duration;
        }
    }
}
