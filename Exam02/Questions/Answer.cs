using System;

namespace Exam02
{
    public class Answer : ICloneable
    {
        public int AnswerId { get; set; }
        public string Text { get; set; }

        public Answer(int id, string text)
        {
            AnswerId = id;
            Text = text;
        }

        public override string ToString()
        {
            return $"{AnswerId}. {Text}";
        }

        public object Clone()
        {
            return new Answer(AnswerId, Text);
        }
    }
}
