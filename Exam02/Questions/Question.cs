using System;
using System.Collections.Generic;

namespace Exam02.Questions
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public List<Answer> AnswerList { get; set; }
        public Answer RightAnswer { get; set; }
        public Answer UserAnswer { get; set; }

        public Question(string body, int mark, string header = "")
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = new List<Answer>();
        }

        public abstract void Show();

        public override string ToString()
        {
            return $"{Header}\n{Body}\nMark: {Mark}";
        }

        public object Clone()
        {
            Question copy = (Question)MemberwiseClone();
            copy.AnswerList = new List<Answer>();
            foreach (var ans in AnswerList)
                copy.AnswerList.Add((Answer)ans.Clone());
            return copy;
        }

        public int CompareTo(Question other)
        {
            return Mark.CompareTo(other.Mark);
        }
    }
}
