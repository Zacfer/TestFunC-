using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFun
{
    class Participant
    {
        public string Name
        {
            get;
        }
       public int Score
        {
            get;
        }
        public decimal Prize
        {
            get;
            set;
        }

        public Participant(string name, int score, decimal prize)
        {
            this.Name = name;
            this.Score = score;
            this.Prize = prize;
        }

        public Participant(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Score: {Score}, Prize: {Prize}";
        }
    }
}
