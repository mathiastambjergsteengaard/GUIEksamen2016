using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIVinterEksamen20152016
{
    public class QuizMaster
    {
        public void NewQuestion(QuizView.CurrentQuestion cur, QuestionAnswer que)
        {
            cur.Question = que.Question;
            cur.A = que.A;
            cur.B = que.B;
            cur.C = que.C;
            cur.D = que.D;
            cur.RightAnswer = que.RightAnswer;
        }

        public int localCounter { get; set; }
        public int Counter { get; set; }
    }
}
